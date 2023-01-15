private void btnInloggen_Click(object sender, EventArgs e)
{
    if(LoginController.LogInUser(tbGebruikersnaam.Text, tbWachtwoord.Text))
    {
        this.Close();
    }
    else
    {
        DialogResult res = MessageBox.Show("De gegevens zijn onjuist, probeer opnieuw", "Fout!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
        if(res == DialogResult.Retry) 
        {
            Application.Restart();
        }
        else
        {
            Application.Exit();
        }
    }
}

private void Form1_Load(object sender, EventArgs e)
{
  if(LoginController.savedUsername == "") 
  {
      MessageBox.Show("Probeerde je nu echt in te loggen zonder gegevens...", "Serieus!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
      Application.Exit();
  }

  lblNaam.Text = LoginController.savedUsername;
  lblWachtwoord.Text = LoginController.savedPassword;

  switch(LoginController.savedRole)
  {
      case 1:
          lblRol.Text = "";
          return;
      case 2:
          lblRol.Text = "";
          return;
      case 3:
          lblRol.Text = "";
          return;
      default: return;
  }
}    

public static string savedUsername = "";
public static string savedPassword = "";
public static int savedRole = -1;

public static bool LogInUser(string sendUsername, string sendPassword)
{
    if (sendUsername.ToLower() == "kaas" || sendPassword.ToLower() == "kaas")
    {
        savedUsername = sendUsername;
        savedPassword = sendPassword;
        savedRole = 3;
        return true;
    }
    else
    {
        return false;
    }
}
