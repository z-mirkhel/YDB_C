using Newtonsoft.Json;
using System.Data;
using System.Drawing;
using System.Xml;
using Ydb.Sdk.Services.Table;
using Ydb.Sdk;
using Ydb.Sdk.Auth;

namespace YDBwithForms
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        DataTable dataTable2 = new DataTable();
        DataTable dataTable3 = new DataTable();
        int countAll;
        int priceAll;
        int rowCount;
        public Driver driver;
        private int intRow = 0;

        public Form1()
        {
            InitializeComponent();
            InitDB();
        }

        private async Task InitDB()
        {
            // Чтение файла ключа и получение IAM-токена
            string json = File.ReadAllText(Config.keyPath);
            YDBwithForms.ServiceAccount account = JsonConvert.DeserializeObject<YDBwithForms.ServiceAccount>(json);

            var _ = new IAMToken();
            string? iamToken = await _.createAsync(account.private_key, account.id, account.service_account_id);


            // Обращение к YaDB
            var config = new DriverConfig(
                endpoint: Config.UserEndpoint,
                database: Config.UserDatabasePath,
                credentials: new Ydb.Sdk.Auth.TokenProvider(iamToken)
            );

            driver = new Driver(
                config: config
            );

            await driver.Initialize();
            loadComboBoxProduct();
        }

        private async Task loadComboBoxProduct()
        {
            var tableClient = new TableClient(driver, new TableClientConfig());

            DataTable dt = new DataTable();

            var response = await tableClient.SessionExec(async session =>
            {
                var query = @$"SELECT id_product, name_product FROM products";

                return await session.ExecuteDataQuery(
                query: query,
                txControl: TxControl.BeginSerializableRW().Commit()
                );
            });
            response.Status.EnsureSuccess();
            var queryResponse = (ExecuteDataQueryResponse)response;
            var resultSet = queryResponse.Result.ResultSets[0];

            foreach (var row in resultSet.Rows)
            {
                dt.Rows.Add((ulong?)row["id_product"], (string?)row["name_product"]);
            }
            if (dt.Rows.Count > 0)
            {
                intRow = Convert.ToInt32(dt.Rows.Count.ToString());
            }
            else
            {
                intRow = 0;
            }

            //формируем запрос к БД (выборка данных)
            //отображаем данные в comboBox
            comboBoxProduct.DisplayMember = "name_product";
            comboBoxProduct.ValueMember = "id_product";
            comboBoxProduct.DataSource = dt;


            //DataTable dt2 = new DataTable();
            //формируем запрос к БД (выборка данных)
            // NpgsqlDataAdapter adap2 = new NpgsqlDataAdapter("SELECT * FROM clients", con);
            // adap2.Fill(dt2);
            //отображаем данные в comboBox
            //comboBoxFIO.DisplayMember = "name_client";
            //comboBoxFIO.ValueMember = "id_client";
            //comboBoxFIO.DataSource = dt2;
        }

        /*private void loadOrder()
        {
            DataTable dt = new DataTable();
            //формируем запрос к БД (выборка данных)
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM orders", con);
            adap.Fill(dt);
            //отображаем данные в dataGridView2
            dataGridView2.DataSource = dt;
        }*/
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            CreateNewClientForm createNewClient = new CreateNewClientForm();
            createNewClient.ShowDialog();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            string product = comboBoxProduct.Text;
            int count = int.Parse(textBoxCount.Text);
            int price = int.Parse(textBoxPrice.Text);

            DataTable dt = new DataTable();

            // NpgsqlDataAdapter adap = new NpgsqlDataAdapter($"SELECT price_one FROM products WHERE name_product LIKE N'%{product}%'", con);
            // adap.Fill(dt);
            
            /*var tableClient = new TableClient(driver, new TableClientConfig());

            var response = await tableClient.SessionExec(async session =>
            {
                var query = @$"SELECT count_product FROM products
                                        WHERE name_product={product};";

                return await session.ExecuteDataQuery(
                query: query,
                txControl: TxControl.BeginSerializableRW().Commit()
                );
            });
            response.Status.EnsureSuccess();
            var queryResponse = (ExecuteDataQueryResponse)response;
            var resultSet = queryResponse.Result.ResultSets[0];

            foreach (var row in resultSet.Rows)
            {
                dt.Rows.Add((ulong?)row[0]);
            }

            if ((int.Parse(dt.Rows[0][0].ToString()) < count))
                MessageBox.Show($"Имеющееся кол-во товара на складе: {int.Parse(dt.Rows[0][0].ToString())}, \n" +
                    $"пожалуйста, уменьшите кол-во товара в заказе\n" +
                    $" или выберете другой товар", "Товар не может быть заказан", MessageBoxButtons.OK);

            */
            //textBoxPrice.Text = dt.Rows[0][0].ToString();

            dataTable.Rows.Add(product, count, price * count);
            dataGridView1.DataSource = dataTable;

            rowCount = dataTable.Rows.Count;
            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    countAll += int.Parse(dataGridView1[1, i].Value.ToString());
                    priceAll += int.Parse(dataGridView1[2, i].Value.ToString());
                }
            }
            textBoxCountAll.Text = countAll.ToString();
            textBoxPriceAll.Text = priceAll.ToString();
            countAll = 0;
            priceAll = 0;
        }

        private void textBoxCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBoxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataTable.Columns.Add("Product", typeof(string));
            dataTable.Columns.Add("Count", typeof(int));
            dataTable.Columns.Add("Price", typeof(int));
            dataGridView1.DataSource = dataTable;

            dataTable2.Columns.Add("Client", typeof(string));
            dataTable2.Columns.Add("Name Product", typeof(string));
            dataTable2.Columns.Add("Count", typeof(int));
            dataTable2.Columns.Add("Price All", typeof(int));
            dataGridView2.DataSource = dataTable2;

            dataTable3.Columns.Add("Client", typeof(string));
            dataTable3.Columns.Add("Day Before", typeof(string));
            dataTable3.Columns.Add("Day After", typeof(string));
            dataTable3.Columns.Add("Price Summ", typeof(int));
            dataTable3.Columns.Add("Dost Summ", typeof(string));
            dataGridView3.DataSource = dataTable3;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;


            countAll = int.Parse(textBoxCountAll.Text);
            priceAll = int.Parse(textBoxPriceAll.Text);
            rowCount = dataTable.Rows.Count;
            if (rowCount > 0)
            {
                countAll -= int.Parse(dataGridView1[1, rowIndex].Value.ToString());
                priceAll -= int.Parse(dataGridView1[2, rowIndex].Value.ToString());
            }
            textBoxCountAll.Text = countAll.ToString();
            textBoxPriceAll.Text = priceAll.ToString();


            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void buttonCreateOreder_Click(object sender, EventArgs e)
        {
            rowCount = dataTable.Rows.Count;
            if (rowCount > 0)
            {
                for (int i = 0; i < rowCount; i++)
                {
                    string Client = comboBoxFIO.Text;
                    string product = dataGridView1[0, i].Value.ToString();
                    int count = int.Parse(textBoxCountAll.Text);
                    int price = int.Parse(textBoxPriceAll.Text);
                    dataTable2.Rows.Add(Client, product, count, price);
                    dataGridView2.DataSource = dataTable2;

                }

                MessageBox.Show("Данные успешно сохранены", "Заказ оформлен!", MessageBoxButtons.OK);

            }
        }

        private void buttonForm_Click(object sender, EventArgs e)
        {
            string client = comboBoxFIO.Text.ToString();
            string day = comboBoxBefore.Text.ToString();
            string day2 = comboBoxAfter.Text.ToString();
            int price = 0;
            string dost_count;

            DataTable dt = new DataTable();
            // NpgsqlDataAdapter adap = new NpgsqlDataAdapter($"SELECT price_all FROM dost WHERE day_dost >= '{day}'::date OR day_dost <= '{day2}'::date AND name_client = '{client}'", con);
            // adap.Fill(dt);


            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow row = dt.Rows[i];
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    price = price + (int)row[j];
                }
            }


            DataTable dt2 = new DataTable();
            // NpgsqlDataAdapter adap2 = new NpgsqlDataAdapter($"SELECT count(*) FROM dost WHERE day_dost >= '{day}'::date OR day_dost <= '{day2}'::date AND name_client = '{client}'", con);
            // adap2.Fill(dt2);
            dost_count = dt2.Rows[0][0].ToString();

            dataTable3.Rows.Add(client, day, day2, price, dost_count);
            dataGridView3.DataSource = dataTable3;

            XmlWriter xmlWriter = XmlWriter.Create("otchet.xml");

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("clients");

            xmlWriter.WriteStartElement("client");
            xmlWriter.WriteAttributeString("day_before", $"{day}");
            xmlWriter.WriteAttributeString("day_after", $"{day2}");
            xmlWriter.WriteAttributeString("price_all", $"{price}");
            xmlWriter.WriteAttributeString("dost_all", $"{dost_count}");
            xmlWriter.WriteString($"{client}");
            xmlWriter.WriteEndElement();

            MessageBox.Show("Данные успешно сохранены", "", MessageBoxButtons.OK);

            xmlWriter.Close();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DataTable dt2 = new DataTable();
            //формируем запрос к БД (выборка данных)
            // NpgsqlDataAdapter adap2 = new NpgsqlDataAdapter("SELECT * FROM clients", con);
            // adap2.Fill(dt2);
            //отображаем данные в comboBox
            comboBoxFIO.DisplayMember = "name_client";
            comboBoxFIO.ValueMember = "id_client";
            comboBoxFIO.DataSource = dt2;
        }

        private void buttonDate_Click(object sender, EventArgs e)
        {
            string client = comboBoxFIO.Text;

            DataTable dt3 = new DataTable();
            // формируем запрос к БД (выборка данных)
            // NpgsqlDataAdapter adap3 = new NpgsqlDataAdapter($"SELECT * FROM dost WHERE name_client = '{client}'", con);
            // adap3.Fill(dt3);
            // отображаем данные в comboBox
            comboBoxBefore.DisplayMember = "day_dost";
            comboBoxBefore.ValueMember = "id_dost";
            comboBoxBefore.DataSource = dt3;

            DataTable dt4 = new DataTable();
            //формируем запрос к БД (выборка данных)
            // NpgsqlDataAdapter adap4 = new NpgsqlDataAdapter($"SELECT * FROM dost WHERE name_client = '{client}'", con);
            // adap4.Fill(dt4);
            //отображаем данные в comboBox
            comboBoxAfter.DisplayMember = "day_dost";
            comboBoxAfter.ValueMember = "id_dost";
            comboBoxAfter.DataSource = dt4;
        }
    }
}