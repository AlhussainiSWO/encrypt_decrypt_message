namespace Decryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DecryptedMessage(string userInput)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' };

            char[] input = userInput.ToCharArray();
            char[] decryptedOutput = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                char messagePosition = input[i];
                if (char.IsWhiteSpace(messagePosition))
                {
                    int alphabetChar = Array.IndexOf(alphabet, messagePosition);
                    int newAlphabetChar = (alphabetChar - 3 + alphabet.Length) % alphabet.Length;
                    char newMessagePosition = alphabet[newAlphabetChar];
                    decryptedOutput[i] = newMessagePosition;
                }
                else if (char.IsLetterOrDigit(messagePosition))
                {
                    if (char.IsDigit(messagePosition))
                    {
                        decryptedOutput[i] = messagePosition;
                    }
                    else
                    {
                        int alphabetChar = Array.IndexOf(alphabet, messagePosition);
                        int newAlphabetChar = (alphabetChar - 3 + alphabet.Length) % alphabet.Length;
                        char newMessagePosition = alphabet[newAlphabetChar];
                        decryptedOutput[i] = newMessagePosition;
                    }
                }
            }
                var decryptedOutputString = new string(decryptedOutput);

            if (decryptedOutputLabel != null)
            {
            decryptedOutputLabel.Text = (decryptedOutputString);
            }
        }



        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            DecryptedMessage(userInput.Text);
        }
    }
}