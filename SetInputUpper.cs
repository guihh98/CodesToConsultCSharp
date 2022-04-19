//PUT THIS METHOD IN A CLASS TO USE ALL THE TIME
 public static string Maiusculo(string texto)
        {
            return texto.ToUpper();
        }


//IN YOUR INPUT PASTE THIS CODE

 private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // The name of my class is 'FormatacoesDeCampos' and the method is 'Maiuscolo'. I wrote in portuguese
            TextBox.Text = FormatacoesDeCampos.Maiusculo(TextBox.Text); 

            //we need set the cursor on the end. so i need this
            TextBox.SelectionStart = TextBox.Text.Length;
            TextBox.SelectionLength = 0;
        }

        // NOTES
        // DON'T FORGET INITIALIZE THE CKASS