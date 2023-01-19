namespace Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };

        private void encryptPassword(string userInput)
        {
            char[] input = userInput.ToCharArray();
            char[] encryptedOutput = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char messagePosition = input[i];
                if (char.IsWhiteSpace(messagePosition))
                {
                    int alphabetChar = Array.IndexOf(alphabet, messagePosition);
                    int newAlphabetChar = (alphabetChar + 3) % (alphabet.Length);
                    char newMessagePositon = alphabet[newAlphabetChar];
                    encryptedOutput[i] = newMessagePositon;
                }
                else if (char.IsLetterOrDigit(messagePosition))
                {
                    if (char.IsDigit(messagePosition))
                    {
                        encryptedOutput[i] = messagePosition;
                    }
                    else
                    {
                        int alphabetChar = Array.IndexOf(alphabet, messagePosition);
                        int newAlphabetChar = (alphabetChar + 3) % (alphabet.Length);
                        char newMessagePositon = alphabet[newAlphabetChar];
                        encryptedOutput[i] = newMessagePositon;
                    }
                }
            }
            var encryptedOutputString = new string(encryptedOutput);
            if (encryptedOutputLabel != null)
            {
                encryptedOutputLabel.Text = (encryptedOutputString);
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            encryptPassword(userInput.Text);
        }
       

    }
}