using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Prism.Commands;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Data;
using System.Collections.ObjectModel;
using System.Windows;
using System.ComponentModel;

namespace T5008SlipView.ViewModels
{
    public interface ISelectable
    {
        bool IsSelected { get; set; }
    }
    public class T5008SlipModel : BindableBase, ISelectable
    {
        private List<string> actionList;
        private string selectedAction;
        private string cost;
        private string gross;
        private string history;
        private bool isSelected;
        private string issuer;
        private string type;
        private string heading;

        private int totalSlips;
        private List<T5008SlipDetail> t5008slips;

        public T5008SlipModel()
        {
            
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

        private bool isExpanded;
        public bool IsExpanded
        {
            get { return isExpanded; }
            set
            {
                isExpanded = value;
                OnPropertyChanged(() => IsExpanded);
            }
        }
        
        public Guid Id { get; set; }

        public string History
        {
            get { return history; }
            set
            {
                history = value;
                OnPropertyChanged(() => History);
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                type = value;
                this.OnPropertyChanged(() => Type);
            }
        }

        public string Heading
        {
            get { return heading; }
            set
            {
                heading = value;
                OnPropertyChanged(() => Heading);
            }
        }

        public string Issuer
        {
            get { return issuer; }
            set
            {
                issuer = value;
                OnPropertyChanged(() => Issuer);
            }
        }

        public string Gross
        {
            get { return gross; }
            set
            {
                gross = value;
                OnPropertyChanged(() => Gross);
            }
        }

        public string Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged(() => Cost);
            }
        }

        public string ActionText
        {
            get { return "ACTION"; }
        }

        public bool IsSelected
        {
            get { return isSelected; }
            set
            {
                isSelected = value;
                OnPropertyChanged(() => IsSelected);
            }
        }

        public List<string> SlipActionList
        {
            get { return actionList; }
            set
            {
                actionList = value;
                OnPropertyChanged(() => SlipActionList);
            }
        }

        public string SelectedAction
        {
            get { return selectedAction; }
            set
            {
                selectedAction = value;
                OnPropertyChanged(() => SelectedAction);
            }
        }

        // To show total slips
        public int TotalSlips
        {
            get { return totalSlips; }
            set
            {
                totalSlips = value;
                OnPropertyChanged(() => TotalSlips);
            }
        }

        public List<T5008SlipDetail> T5008SlipExpand
        {
            get { return t5008slips; }
            set
            {
                t5008slips = value;
                OnPropertyChanged(() => T5008SlipExpand);
            }
        }

        public DelegateCommand<object> IndeterminateTestCommand { get; set; }

    }
    public class T5008SlipDetail : BaseSlipDetail
    {
        public String History { get; set; }

        public String Issuer { get; set; }

        public Decimal GrossAmount { get; set; }

        public Decimal CostAmount { get; set; }
    }
    public abstract class BaseSlipDetail
    {
        public Guid Id { get; set; }

        // To show slip names 
        public String SlipName { get; set; }

        //To show slip type
        public string SlipType { get; set; }

        // Ignore on worksheet 
        public String GroupName { get; set; }

        // Ignore on worksheet 
        public int GroupIndex { get; set; }

        // To show slip heading like T4, T5
        public String SlipHeading { get; set; }

        // To show list of actions
        public List<ActionList> ActionInfo { get; set; }

        // To get import action from worksheet
        public string ImportAction { get; set; } // like add or like rep0 rep1

        public bool IsImport { get; set; }
    }
    public class ActionList
    {
        // To show in action list
        public string SlipName { get; set; }

        // Ignore on worksheet 
        public String GroupName { get; set; }

        // Ignore on worksheet 
        public int GroupIndex { get; set; }
    }


}
