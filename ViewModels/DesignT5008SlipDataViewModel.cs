using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace T5008SlipView.ViewModels
{
    public class DesignModel_GroupByIssuer : T5008SlipViewModel
    {
        private ObservableCollection<T5008SlipViewModel> t5008Slips;

        public DesignModel_GroupByIssuer()
        {
            t5008Slips = new ObservableCollection<T5008SlipViewModel>();
            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("1ab8bcfe-b778-4d37-ae8b-1040ec2a7238"),
                History = "GOOG",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer= "CIBC",
                Gross="1021.21",
                Cost="2020.20",
                IsSelected=false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips=0,
                T5008SlipExpand= new List<T5008SlipDetail>()
            });
            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("1ab8bcfe-b778-4d37-ae8b-1040ec2a7238"),
                History = "APPL",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "CIBC",
                Gross = "1021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("eadf738a-066a-464e-92b1-509481e5b094"),
                History = "GOOG",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "QuestTrade",
                Gross = "1021.21",
                Cost = "2020.22",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("a0288471-2d32-402a-99e1-0c94b02af751"),
                History = "GOOG",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "QuestTrade",
                Gross = "1021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ad-4fe1-a053-c45ec70eccbc"),
                History = "TSLA",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "TD WaterHouse",
                Gross = "1021.21",
                Cost = "2020.24",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ad-4fe1-a053-c45ec70eccbc"),
                History = "APPL",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "RBC",
                Gross = "1021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ad-4fe1-a053-c45ec70eccbc"),
                History = "FB",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "TD WaterHouse",
                Gross = "1021.21",
                Cost = "2125.23",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ae-4fe1-a053-c45ec70eccbc"),
                History = "MSFT",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "Fidelity",
                Gross = "2021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ae-4fe1-a053-c45ec70eccbc"),
                History = "MSFT",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "Fidelity",
                Gross = "2021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ae-4fe1-a053-c45ec70eccbc"),
                History = "MSFT",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "TD WaterHouse",
                Gross = "2021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ae-4fe1-a053-c45ec70eccbc"),
                History = "BBRY",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "TD WaterHouse",
                Gross = "2021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ae-4fe1-a053-c45ec70eccbc"),
                History = "MSFT",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "Scott Trade",
                Gross = "2021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });
            T5008Slips.Add(new T5008SlipViewModel()
            {
                Id = Guid.Parse("dea9f65f-68ae-4fe1-a053-c45ec70eccbc"),
                History = "MSFT",
                Type = "T5008 Statement",
                Heading = "T5008 Statement",
                Issuer = "Sun Financial",
                Gross = "2021.21",
                Cost = "2020.20",
                IsSelected = false,
                SlipActionList = new List<string>()
                {
                    "Add As New"
                },
                TotalSlips = 0,
                T5008SlipExpand = new List<T5008SlipDetail>()
            });

        }
        public ObservableCollection<T5008SlipViewModel> T5008Slips
        {
            get { return t5008Slips; }
            set
            {
                t5008Slips = value;
                OnPropertyChanged(() => T5008Slips);
            }
        }
        private bool isExpanded = false;
        public bool IsExpanded
        {
            get { return isExpanded; }
            set { isExpanded = value; }
        }


        private ICommand toggleExpandAllCommand;

        public ICommand ToggleExpandAllCommand
        {
            get { return toggleExpandAllCommand; }
            set
            {
                toggleExpandAllCommand = value;

                OnPropertyChanged(() => ToggleExpandAllCommand);
            }
        }

    }
}
