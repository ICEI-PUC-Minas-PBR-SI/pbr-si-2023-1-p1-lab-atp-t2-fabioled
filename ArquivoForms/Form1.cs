using System.Diagnostics;
using System.IO;
namespace ArquivoForms
{
    public partial class Form1 : Form
    {

        private string strPathFile = @"C:\temp\ArquivoExemplo.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            Criar();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            Concatenar();
        }
        private void Criar()
        {
            try
            {
��������������� //Usarei a cl�usula using como boas pr�ticas de programa��o em todos os m�todos
��������������� //Instancio a classe FileStream, uso a classe File e o m�todo Create para criar o
��������������� //arquivo passando como par�metro a vari�vel strPathFile, que cont�m o arquivo
��������������� using (FileStream fs = File.Create(strPathFile))
                {
������������������� //Crio outro using, dentro dele instancio o StreamWriter (classe para gravar os dados)
������������������� //que recebe como par�metro a vari�vel fs, referente ao FileStream criado anteriormente
������������������� using (StreamWriter sw = new StreamWriter(fs))
                    {
����������������������� //Uso o m�todo Write para escrever algo em nosso arquivo texto
����������������������� sw.Write("Texto adicionado ao exemplo!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
����������� //Se tudo ocorrer bem, exibo a mensagem ao usu�rio.
����������� MessageBox.Show("Arquivo criado com sucesso!!!");
        }

        private void Abrir()
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo(strPathFile)
            {
                UseShellExecute = true
            };
            p.Start();
            try
            {
��������������� //Verifico se o arquivo que desejo abrir existe e passo como par�metro a respectiva vari�vel
��������������� if (File.Exists(strPathFile))
                {
������������������� //Se existir "starto" um processo do sistema para abrir o arquivo e, sem precisar
������������������� //passar ao processo o aplicativo a ser aberto, ele abre automaticamente o Notepad
������������������� System.Diagnostics.Process.Start(strPathFile);
                }
                else
                {
������������������� //Se n�o existir exibo a mensagem
������������������� MessageBox.Show("Arquivo n�o encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Concatenar()
        {
            try
            {
                // Verifico se o arquivo que desejo 
                // abrir existe e passo como par�metro a 
                // respectiva vari�vel
                if (File.Exists(strPathFile))
                {
                    // Crio um using, dentro dele  instancio  StreamWriter, uso a classe File e o  m�todo
                    // AppendText para concatenar o    texto, passando como par�metro a   vari�vel strPathFile
                    using (StreamWriter sw = File.AppendText(strPathFile))
                    {
                        // Uso o m�todo Write para escrever o arquivo 
                        // que ser� adicionado no arquivo text
                        sw.Write("\r\nTexto adicionado ao final do arquivo");
                    }
                    // Exibo a mensagem que o arquivo foi atualizado
                    MessageBox.Show("Arquivo atualizado!");
                }
                else
                {
                    // Se n�o existir exibo a mensagem
                    MessageBox.Show("Arquivo n�o encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}