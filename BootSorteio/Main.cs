using System;
using System.Net;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.IO;
using System.Linq;
using Cookie = OpenQA.Selenium.Cookie;

namespace BootSorteio
{
    public partial class Main : Form
    {
        IWebDriver driver; 
        private ToolTip meuToolTip;

        int repete = 5;
        string url;
        string email;
        string senha;
        public Main()
        {
            InitializeComponent();

            meuToolTip = new ToolTip();
            txtSenha.PasswordChar = '*';
            houver();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            

            if (valida() == true)
            {
                driver = new ChromeDriver();
                login(email, senha, url);
                Thread.Sleep(1000);
                checkBox_verifica();
            }
            
        }
        private void valida(object sender, EventArgs e)
        {
            if (chbEscolhe.Checked)
            {
                chkbVouganhar.Visible = false;
                chkbJaganhei.Visible = false;
                chkBEuquero.Visible = false;
                chkbCidades.Visible = false;
                chkbEstados.Visible = false;
                chkbPaises.Visible = false;
                chbMarcar.Visible = false;

                txtbEscolhe.Visible = true;

            }
            else
            {
                chkbVouganhar.Visible = true;
                chkbJaganhei.Visible = true;
                chkBEuquero.Visible = true;
                chkbCidades.Visible = true;
                chkbEstados.Visible = true;
                chkbPaises.Visible = true;
                chbMarcar.Visible = true;
                txtbEscolhe.Visible = false;
            }

             if (chbMarcar.Checked)
            {
                txtbMarcar.Visible = true;
            }else
                txtbMarcar.Visible = false;
        }
        public void checkBox_verifica()
        {
            Thread.Sleep(1000);
            if (chbEscolhe.Checked)
            {

                Thread.Sleep(1000);
                repetir(txtbEscolhe.Text.Trim());
            }
            else if (chbMarcar.Checked)
            {
                Thread.Sleep(1000);
                marcar(txtbMarcar.Text.Trim());
            }

            else if (chkbVouganhar.Checked)
            {
                Thread.Sleep(1000);
                repetir("Vou ganhar!");
            }
            else if(chkbJaganhei.Checked)
            {
                Thread.Sleep(1000);
                repetir("Já ganhei!");
            }
            else if(chkBEuquero.Checked)
            {
                Thread.Sleep(1000);
                repetir("Eu quero!");
            }
            else if(chkbCidades.Checked)
            {
                Thread.Sleep(1000);
                cidade();
            }
            else if(chkbEstados.Checked)
            {
                Thread.Sleep(1000);
                estado();
            }
            else if(chkbPaises.Checked)
            {
                Thread.Sleep(1000);
                pais();
            }
        }

        public void login(string email, string senha, string url)
        {
            driver.Navigate().GoToUrl(url);
            driver.Manage().Window.Maximize();

            var _cookies = driver.Manage().Cookies.AllCookies;

            foreach (Cookie cookie in _cookies)
            {
                driver.Manage().Cookies.AddCookie(cookie);
            }

            driver.FindElement(By.ClassName("tdiEy")).Click();
            Thread.Sleep(2000);

            var login = driver.FindElement(By.Name("username"));
            login.SendKeys(email);
            login = driver.FindElement(By.Name("password"));
            login.SendKeys(senha);
            login.Submit();
        }

        public bool valida()
        {
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                MessageBox.Show("Email é obrigatorio","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
                
            }
            if (string.IsNullOrEmpty(txtSenha.Text.Trim()))
            {
                MessageBox.Show("Senha é obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSenha.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtUrl.Text.Trim()))
            {
                MessageBox.Show("URL é obrigatorio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUrl.Focus();
                return false;
            }

            email = txtEmail.Text.Trim();
            senha = txtSenha.Text;
            url = txtUrl.Text;

            return true;
        }
        public void repetir(string texto)
        {
            for (int i = 0; 100 >= i; i++)
            {
                for (int j = 0; repete >= j; j++)
                {
                    //da um tempo para a pagina carregar
                    Thread.Sleep(1000);
                    //procurar um textarea e clica para dps escrever
                    driver.FindElement(By.TagName("textarea")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.TagName("textarea")).SendKeys(texto);
                    Thread.Sleep(1000);
                    //procurar o botao com o tipo de enviar
                    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                    Thread.Sleep(1000);
                    driver.Navigate().GoToUrl(url);
                    Thread.Sleep(62000);
                }

                Thread.Sleep(62000);//1,2min
            }

            driver.Quit();
        }
        public void cidade()
        {
            //Declaro o StreamReader para o caminho onde se encontra o arquivo 
            StreamReader rd = new StreamReader(@"cidades.csv");
            //Declaro uma string que será utilizada para receber a linha completa do arquivo 
            string linha = null;
            //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado 
            string[] linhaseparada = null;
            //realizo o while para ler o conteudo da linha 
            while ((linha = rd.ReadLine()) != null)
            {
                //com o split adiciono a string 'quebrada' dentro do array 
                linhaseparada = linha.Split(';');
                //aqui incluo o método necessário para continuar o trabalho 
                for(int i = 0; linhaseparada.Length >=i; i++)
                {
                    // da um tempo para a pagina carregar
                    Thread.Sleep(1000);
                    //procurar um textarea e clica para dps escrever
                    driver.FindElement(By.TagName("textarea")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.TagName("textarea")).SendKeys(linhaseparada[i]);

                    Thread.Sleep(1000);
                    //procurar o botao com o tipo de enviar
                    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                    Thread.Sleep(1000);
                    driver.Navigate().GoToUrl(url);

                    Thread.Sleep(62000);
                }
                
            }

            driver.Quit();
        }

        public void estado()
        {
            //Declaro o StreamReader para o caminho onde se encontra o arquivo 
            StreamReader rd = new StreamReader(@"estados.csv");
            //Declaro uma string que será utilizada para receber a linha completa do arquivo 
            string linha = null;
            //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado 
            string[] linhaseparada = null;
            //realizo o while para ler o conteudo da linha 
            while ((linha = rd.ReadLine()) != null)
            {
                //com o split adiciono a string 'quebrada' dentro do array 
                linhaseparada = linha.Split(';');
                //aqui incluo o método necessário para continuar o trabalho 
                for (int i = 0; linhaseparada.Length >= i; i++)
                {
                    // da um tempo para a pagina carregar
                    Thread.Sleep(1000);
                    //procurar um textarea e clica para dps escrever
                    driver.FindElement(By.TagName("textarea")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.TagName("textarea")).SendKeys(linhaseparada[i]);

                    Thread.Sleep(1000);
                    //procurar o botao com o tipo de enviar
                    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                    Thread.Sleep(1000);
                    driver.Navigate().GoToUrl(url);

                    Thread.Sleep(62000);
                }

            }

            driver.Quit();
        }
        public void pais()
        {
            //Declaro o StreamReader para o caminho onde se encontra o arquivo 
            StreamReader rd = new StreamReader(@"paises.csv");
            //Declaro uma string que será utilizada para receber a linha completa do arquivo 
            string linha = null;
            //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado 
            string[] linhaseparada = null;
            //realizo o while para ler o conteudo da linha 
            while ((linha = rd.ReadLine()) != null)
            {
                //com o split adiciono a string 'quebrada' dentro do array 
                linhaseparada = linha.Split(';');
                //aqui incluo o método necessário para continuar o trabalho 
                for (int i = 0; linhaseparada.Length >= i; i++)
                {
                    // da um tempo para a pagina carregar
                    Thread.Sleep(1000);
                    //procurar um textarea e clica para dps escrever
                    driver.FindElement(By.TagName("textarea")).Click();
                    Thread.Sleep(1000);
                    driver.FindElement(By.TagName("textarea")).SendKeys(linhaseparada[i]);

                    Thread.Sleep(1000);
                    //procurar o botao com o tipo de enviar
                    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                    Thread.Sleep(1000);
                    driver.Navigate().GoToUrl(url);

                    Thread.Sleep(62000);
                }

            }

            driver.Quit();
        }
        public void marcar(string qtd)
        {
            StreamReader rd = new StreamReader(@"amigos.csv");
            //Declaro uma string que será utilizada para receber a linha completa do arquivo 
            string linha = null;
            int cont = 0;
            //Declaro um array do tipo string que será utilizado para adicionar o conteudo da linha separado 
            string[] linhaseparada = null;
            //realizo o while para ler o conteudo da linha 
            while ((linha = rd.ReadLine()) != null)
            {
                //com o split adiciono a string 'quebrada' dentro do array 
                linhaseparada = linha.Split(';');
                //aqui incluo o método necessário para continuar o trabalho 
                for (int i = 0; linhaseparada.Length >= i; i++)
                {
                    cont = 0;
                    // da um tempo para a pagina carregar
                    Thread.Sleep(1000);
                    //procurar um textarea e clica para dps escrever
                    driver.FindElement(By.TagName("textarea")).Click();
                    Thread.Sleep(1000);

                    while (cont != int.Parse(qtd))
                    {
                        driver.FindElement(By.TagName("textarea")).SendKeys("@"+linhaseparada[i]);
                        driver.FindElement(By.TagName("textarea")).SendKeys(", ");
                        i++; cont++;
                    }

                    Thread.Sleep(1000);
                    //procurar o botao com o tipo de enviar
                    driver.FindElement(By.XPath("//button[@type='submit']")).Click();
                    Thread.Sleep(1000);
                    driver.Navigate().GoToUrl(url);

                    Thread.Sleep(62000);
                }

            }

            driver.Quit();
        }
        private void houver()
        {
            meuToolTip.SetToolTip(chkbCidades, "5564 Cidades");
            meuToolTip.SetToolTip(chkbEstados, "26 Estados");
            meuToolTip.SetToolTip(chkbPaises, "241 Paises");

            
        }

        
    }
}
