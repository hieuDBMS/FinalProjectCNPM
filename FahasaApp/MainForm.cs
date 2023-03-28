using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FahasaApp
{
    public partial class MainForm : Form
    {
        List<Panel> subMenuControl = new List<Panel>();
        List<Button> typeBookControl = new List<Button>();
        public MainForm()
        {
            InitializeComponent();
            initControlLists();
            hideSubMenu();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set Form center Screen
            int screenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int screenHeight = Screen.PrimaryScreen.WorkingArea.Height;
            int formWidth = this.Width;
            int formHeight = this.Height;
            int left = (screenWidth - formWidth) / 2;
            int top = (screenHeight - formHeight) / 2;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(left, top);
        }
        private void initControlLists()
        {
            //Initate panel comtrol for SubMenu
            subMenuControl.Add(panelChildrenBookSubmenu);
            subMenuControl.Add(panelBiography_MemoirsSubMenu);
            subMenuControl.Add(panelEconomySubMenu);
            subMenuControl.Add(panelForeignLanguageBooksSubMenu);
            subMenuControl.Add(panelLiteratureSubMenu);
            subMenuControl.Add(panelPsychology_LifeSkillsSubMenu);
            subMenuControl.Add(panelRaiseUpChildSubMenu);
            subMenuControl.Add(panelText_ReferenceBookSubMenu);

            //Initate Button control for topics of Books
            typeBookControl.Add(btnChildrenBook);
            typeBookControl.Add(btnBiography_MemoirBook);
            typeBookControl.Add(btnEconomyBook);
            typeBookControl.Add(btnForeignLanguagesBook);
            typeBookControl.Add(btnLiteratureBook);
            typeBookControl.Add(btnPsychology_LifeSkillsBook);
            typeBookControl.Add(btnRaiseUpChildBook);
            typeBookControl.Add(btnText_ReferenceBook);


        }

        private void hideSubMenu()
        {
            foreach (Control SubMenu in subMenuControl)
            {
                SubMenu.Visible = false;
            }
        }
        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                //Close all subMenu before opening the new one
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btnChildrenBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelChildrenBookSubmenu);
        }

        private void btnLiteratureBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelLiteratureSubMenu);

        }

        private void btnEconomyBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelEconomySubMenu);

        }

        private void btnPsychology_LifeSkillsBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelPsychology_LifeSkillsSubMenu);

        }

        private void btnRaiseUpChildBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelRaiseUpChildSubMenu);

        }

        private void btnBiography_MemoirBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelBiography_MemoirsSubMenu);
        }

        private void btnText_ReferenceBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelText_ReferenceBookSubMenu);

        }

        private void btnForeignLanguagesBook_Click(object sender, EventArgs e)
        {
            showSubmenu(panelForeignLanguageBooksSubMenu);

        }

       
    }
}
