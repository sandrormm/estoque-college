using System.Windows.Forms;

namespace CSA_SISTEMA
{
    public class Mensagens 
        
    {
        public static void MensagemSucesso(string mensagem)
        {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
        public static void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static void ErroLogin (string mensagem)
            {
            MessageBox.Show(mensagem, "Alerta Erro Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        public static void Informar(string mensagem)
            {
            MessageBox.Show(mensagem, "Informação", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        public static void Alertar(string mensagem)
            {
            MessageBox.Show(mensagem, "Atenção", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        public static void Erro(string mensagem)
            {
            MessageBox.Show(mensagem, "Erro", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }
}
