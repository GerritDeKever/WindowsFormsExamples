using System;
using System.Windows.Forms;
using ProjectName.View;

//  Author:       
//  Date:         
//  Description:  

namespace ProjectName.View
{
    public partial class MainForm : Form
    {
        // For this example we have a reference of a panel set as variable, but most likely you will have a panel in the view this code goes into
        Panel mainPanel;
        
        // When we want to load your view into a main panel, we will use this approach
        private void NameOfYourButton(object sender, EventArgs e)
        {
            // Here we will make a new object of the class which is your own form to insert
            NameOfFormToInsert variableName = new NameOfFormToInsert(mainPanel);

            // Here we will make it a fill the panel it goes into and make sure it has the correct settings
            variableName.Dock = DockStyle.Fill;
            variableName.FormBorderStyle = FormBorderStyle.None;
            variableName.TopLevel = false;

            // Here we clear the panel the new item will go into
            mainPanel.Controls.Clear();

            // Then add the newly created object into it
            mainPanel.Controls.Add(variableName);

            // And lastly we will show the view in the panel
            variableName.Show();
        }
    }
}
