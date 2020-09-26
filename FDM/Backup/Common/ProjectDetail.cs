namespace Common
{
    using System;

    public class ProjectDetail
    {
        private string active_code;
        private string companyEmail;
        private string companyName;
        private string mainConfigFileName;
        private string menuText;
        private string myAdd_CS;
        private int noofhits;
        private string parentMenu;
        private string projectConfigfileName;
        private string projectDBName;
        private string projectName;
        private string projectTitle;
        private string reg_code;
        private bool statusCheck;
        private string year;
        public ProjectDetail()
        {
            this.companyName = "ST Learning Training Institute ®";
            this.projectName = "FDM";
            this.noofhits = 5;
            this.companyEmail = "omer.locs@hotmail.com";
            this.myAdd_CS = "_Net";
            this.menuText = "";
            this.parentMenu = "";
            this.projectConfigfileName = "FDM.config";
            this.projectDBName = "FDM";
            this.mainConfigFileName = "main.config";
            this.projectTitle = "YCDO Hospital & Diagnostic Centre";
            this.year = "2012";
        }

        public ProjectDetail(string regcode, string actcode) : this()
        {
            this.active_code = actcode;
            this.reg_code = regcode;
        }

        public string Active_code
        {
            get
            {
                return this.active_code;
            }
            set
            {
                this.active_code = value;
            }
        }

        public string CompanyEmail
        {
            get
            {
                return this.companyEmail;
            }
            set
            {
                this.companyEmail = value;
            }
        }

        public string CompanyName
        {
            get
            {
                return this.companyName;
            }
        }

        public string MainConfigfileName
        {
            get
            {
                return this.mainConfigFileName;
            }
        }

        public string MenuText
        {
            get
            {
                return this.menuText;
            }
        }

        public string MyAdd_CS
        {
            get
            {
                return this.myAdd_CS;
            }
        }

        public int Noofhits
        {
            get
            {
                return this.noofhits;
            }
            set
            {
                this.noofhits = value;
            }
        }
        public string Year
        {
            get { return this.year; }
        }
        public string ParentMenu
        {
            get
            {
                return this.parentMenu;
            }
        }

        public string ProjectConfigfileName
        {
            get
            {
                return this.projectConfigfileName;
            }
        }

        public string ProjectDBName
        {
            get
            {
                return this.projectDBName;
            }
        }

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
        }

        public string ProjectTitle
        {
            get
            {
                return this.projectTitle;
            }
        }

        public string Reg_code
        {
            get
            {
                return this.reg_code;
            }
            set
            {
                this.reg_code = value;
            }
        }

        public bool StatusCheck
        {
            get
            {
                return this.statusCheck;
            }
            set
            {
                this.statusCheck = value;
            }
        }
    }
}

