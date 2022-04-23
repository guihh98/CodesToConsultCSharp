//past this code when you leave the control
if (txtPrecoVenda.Text != "")
    txtPrecoVenda.Text = Double.Parse(txtPrecoVenda.Text).ToString("C");

// on event KEYPRESS paste this code
if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
{
    e.Handled = true;
}