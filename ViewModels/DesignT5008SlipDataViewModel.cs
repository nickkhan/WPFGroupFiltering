using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace T5008SlipView.ViewModels
{
    public class DesignModel_GroupByIssuer : T5008SlipModel
    {
        private ObservableCollection<T5008SlipModel> t5008Slips;

        public DesignModel_GroupByIssuer()
        {
            t5008Slips = new ObservableCollection<T5008SlipModel>();
            T5008Slips.CollectionChanged += T5008Slips_CollectionChanged;

            SelectAllSlipsInGroupCommand = new DelegateCommand<object>((groupItem) =>
            {
                SetSlipsIsSelectedProperty(groupItem, true);
            });

            DeSelectAllSlipsInGroupCommand = new DelegateCommand<object>((groupItem) =>
            {
                SetSlipsIsSelectedProperty(groupItem, false);
            });

            IndeterminateTestCommand = new DelegateCommand<object>((e) =>
            {
                var sender = e as RoutedEventArgs;
                var chkbox = sender.OriginalSource as CheckBox;
                if (!chkbox.IsChecked.HasValue)
                {
                    SetSlipsIsSelectedProperty((chkbox.DataContext as CollectionViewGroup).Items, false);
                }
            });

            ToggleExpandAllCommand = new DelegateCommand(() => IsExpanded = !IsExpanded);

            T5008Slips.Add(new T5008SlipModel()
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
            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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

            T5008Slips.Add(new T5008SlipModel()
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
            T5008Slips.Add(new T5008SlipModel()
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

        private DelegateCommand<object> selectAllSlipsInGroupCommand;
        public DelegateCommand<object> SelectAllSlipsInGroupCommand
        {
            get
            {
                return selectAllSlipsInGroupCommand;
            }
            set
            {
                selectAllSlipsInGroupCommand = value;
            }
        }

        private DelegateCommand<object> deSelectAllSlipsInGroupCommand;
        public DelegateCommand<object> DeSelectAllSlipsInGroupCommand
        {
            get
            {
                return deSelectAllSlipsInGroupCommand;
            }
            set
            {
                deSelectAllSlipsInGroupCommand = value;
            }
        }

        private void SetSlipsIsSelectedProperty(object groupedItems, bool isSelected)
        {
            var issuerCVG = groupedItems as ReadOnlyObservableCollection<object>;

            foreach (CollectionViewGroup group in issuerCVG)
            {
                foreach (T5008SlipModel item in group.Items)
                {
                    item.IsSelected = isSelected;
                }
            }
        }

        void T5008Slips_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (object t5008Slip in e.NewItems)
                {
                    (t5008Slip as INotifyPropertyChanged).PropertyChanged
                        += new PropertyChangedEventHandler(item_PropertyChanged);
                }
            }

            if (e.OldItems != null)
            {
                foreach (object t5008Slip in e.OldItems)
                {
                    (t5008Slip as INotifyPropertyChanged).PropertyChanged
                        -= new PropertyChangedEventHandler(item_PropertyChanged);
                }
            }
        }

        private void item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            OnPropertyChanged("T5008Slips");
        }

        public ObservableCollection<T5008SlipModel> T5008Slips
        {
            get { return t5008Slips; }
            set
            {
                t5008Slips = value;
                OnPropertyChanged(() => T5008Slips);
            }
        }
    }
}
