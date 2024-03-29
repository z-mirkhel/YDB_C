using Newtonsoft.Json;
using Ydb.Sdk.Services.Table;
using Ydb.Sdk;
using Ydb.Sdk.Value;
using Yandex.Cloud.Mdb.Kafka.V1;

namespace YDBwithForms
{
    public partial class CreateNewClientForm : Form
    {
        public System.Windows.Forms.ComboBox comboBoxFIO;
        ulong id_newClient = 10;
        public string s;
        public string number;
        public string adress;
        public Driver driver;

        public CreateNewClientForm()
                {
                    InitializeComponent();
                    textBoxNewF.Text = "Введите фамилию:";
                    textBoxNewF.ForeColor = Color.Gray;
                    textBoxNewI.Text = "Введите имя:";
                    textBoxNewI.ForeColor = Color.Gray;
                    textBoxNewO.Text = "Введите отчество:";
                    textBoxNewO.ForeColor = Color.Gray;
                    textBoxNewPassword.Text = "Введите адрес доставки:";
                    textBoxNewPassword.ForeColor = Color.Gray;
                }

        public async Task NewClient()
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
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxNewF.Text))
            {
                MessageBox.Show("Введите фамилию!", "Вы не заполнили поле", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(textBoxNewI.Text))
            {
                MessageBox.Show("Введите имя!", "Вы не заполнили поле", MessageBoxButtons.OK);
            }
            //if (string.isnullorempty(textboxnewo.text))
            //{
            //    messagebox.show("введите отчество!", "вы не заполнили поле", messageboxbuttons.ok);
            //}
            if (string.IsNullOrEmpty(maskedTextBoxNewNumber.Text))
            {
                MessageBox.Show("Введите номер телефона!", "Вы не заполнили поле", MessageBoxButtons.OK);
            }
            if (string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                MessageBox.Show("Введите адрес доставки!", "Вы не заполнили поле", MessageBoxButtons.OK);
            }

            if (!string.IsNullOrEmpty(textBoxNewF.Text) &&
                !string.IsNullOrEmpty(textBoxNewI.Text) &&
                !string.IsNullOrEmpty(maskedTextBoxNewNumber.Text) &&
                !string.IsNullOrEmpty(textBoxNewPassword.Text))
            {
                s = this.textBoxNewF.Text + " " + this.textBoxNewI.Text + " " + this.textBoxNewO.Text;
                number = this.maskedTextBoxNewNumber.Text;
                adress = this.textBoxNewPassword.Text;

                //подключение к БД
                NewClient();


                using var tableClient = new TableClient(driver, new TableClientConfig());

                var response = await tableClient.SessionExec(async session =>
                {
                    var query = @$"UPSERT INTO clients(
                                id_client, name_client, number, adress)
                                    VALUES(
                                        {id_newClient}, {s}, 
                                        {number}, {adress}";

                    return await session.ExecuteDataQuery(
                    query: query,
                    txControl: TxControl.BeginSerializableRW().Commit()
                    );
                });
                response.Status.EnsureSuccess();

                this.textBoxNewF.Text = "";
                this.textBoxNewI.Text = "";
                this.textBoxNewO.Text = "";
                this.maskedTextBoxNewNumber.Text = "";
                this.textBoxNewPassword.Text = "";

                MessageBox.Show("Данные успешно сохранены", "Пользователь создан!", MessageBoxButtons.OK);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNewF_Enter(object sender, EventArgs e)
        {
            if (textBoxNewF.Text == "Введите фамилию:")
            {
                textBoxNewF.Text = "";
                textBoxNewF.ForeColor = Color.Black;
            }
        }

        private void textBoxNewF_Leave(object sender, EventArgs e)
        {
            if (textBoxNewF.Text == "")
            {
                textBoxNewF.Text = "Введите фамилию:";
                textBoxNewF.ForeColor = Color.Gray;
            }
        }

        private void textBoxNewI_Enter(object sender, EventArgs e)
        {
            if (textBoxNewI.Text == "Введите имя:")
            {
                textBoxNewI.Text = "";
                textBoxNewI.ForeColor = Color.Black;
            }
        }

        private void textBoxNewI_Leave(object sender, EventArgs e)
        {
            if (textBoxNewI.Text == "")
            {
                textBoxNewI.Text = "Введите имя:";
                textBoxNewI.ForeColor = Color.Gray;
            }
        }

        private void textBoxNewO_Enter(object sender, EventArgs e)
        {
            if (textBoxNewO.Text == "Введите отчество:")
            {
                textBoxNewO.Text = "";
                textBoxNewO.ForeColor = Color.Black;
            }
        }

        private void textBoxNewO_Leave(object sender, EventArgs e)
        {
            if (textBoxNewO.Text == "")
            {
                textBoxNewO.Text = "Введите отчество:";
                textBoxNewO.ForeColor = Color.Gray;
            }
        }

        /*private void maskedTextBoxNewNumber_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxNewNumber.Text == "Введите номер телефона:")
            {
                maskedTextBoxNewNumber.Text = "";
                maskedTextBoxNewNumber.ForeColor = Color.Black;
            }
        }

        private void maskedTextBoxNewNumber_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxNewNumber.Text == "")
            {
                maskedTextBoxNewNumber.Text = "Введите номер телефона:";
                maskedTextBoxNewNumber.ForeColor = Color.Gray;
            }
        }*/

        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "Введите адрес доставки:")
            {
                textBoxNewPassword.Text = "";
                textBoxNewPassword.ForeColor = Color.Black;
            }
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                textBoxNewPassword.Text = "Введите адрес доставки:";
                textBoxNewPassword.ForeColor = Color.Gray;
            }
        }
    }
}