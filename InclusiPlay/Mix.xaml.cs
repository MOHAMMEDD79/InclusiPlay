using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace InclusiPlay
{
    public partial class Mix : Window, INotifyPropertyChanged
    {
        // List of chemicals
        public ObservableCollection<string> Chemicals { get; } = new ObservableCollection<string>();
        public ObservableCollection<Chemical> AvailableChemicals { get; } = new ObservableCollection<Chemical>
        {
            new Chemical { Name = "Water" },
            new Chemical { Name = "Hydrochloric Acid" },
            new Chemical { Name = "Sodium Hydroxide" },
            new Chemical { Name = "Oxygen" },
            new Chemical { Name = "Carbon Dioxide" },
            new Chemical { Name = "Methane" },
            new Chemical { Name = "Ethanol" },
            new Chemical { Name = "Acetone" },
            new Chemical { Name = "Ammonia" },
            new Chemical { Name = "Sulfuric Acid" },
            new Chemical { Name = "Nitric Acid" },
            new Chemical { Name = "Ethylene" },
            new Chemical { Name = "Propane" },
            new Chemical { Name = "Benzene" },
            new Chemical { Name = "Ethylene Glycol" },
            new Chemical { Name = "Methanol" },
            new Chemical { Name = "Propylene" },
            new Chemical { Name = "Formic Acid" },
            new Chemical { Name = "Acetic Acid" },
            new Chemical { Name = "Butane" }
        };

        // Commands
        public ICommand AddChemicalCommand { get; }
        public ICommand MixChemicalsCommand { get; }

        // Experiment result
        private string experimentResult;
        public string ExperimentResult
        {
            get { return experimentResult; }
            set
            {
                if (experimentResult != value)
                {
                    experimentResult = value;
                    OnPropertyChanged(nameof(ExperimentResult));
                }
            }
        }

        // Constructor
        public Mix()
        {
            InitializeComponent();
            DataContext = this;

            AddChemicalCommand = new RelayCommand<string>(AddChemical);
            MixChemicalsCommand = new RelayCommand(MixChemicals);
        }

        // Add chemical to the list
        private void AddChemical(string chemical)
        {
            if (!string.IsNullOrEmpty(chemical))
            {
                Chemicals.Add(chemical);
            }
        }

        // Mix chemicals and generate results
        private void MixChemicals()
        {
            if (Chemicals.Count >= 2)
            {
                string chemical1 = Chemicals[0];
                string chemical2 = Chemicals[1];

                // Get the result of the chemical mixing
                string result = GenerateChemicalEquation(chemical1, chemical2);

                if (!string.IsNullOrEmpty(result))
                {
                    ExperimentResult = result;
                }
                else
                {
                    ExperimentResult = "Unable to generate a chemical equation for these chemicals.";
                }

                // Clear the chemicals after mixing
                Chemicals.Clear();
            }
            else
            {
                ExperimentResult = "Not enough chemicals to mix.";
            }
        }

        // Generate chemical equation based on the mixed chemicals
        private string GenerateChemicalEquation(string chemical1, string chemical2)
        {
            // Your provided chemical reaction cases
            if (chemical1 == "Water" && chemical2 == "Oxygen")
            {
                return "2 H₂O(l) → 2 H₂(g) + O₂(g)\nName of the chemical reaction: Electrolysis of water";
            }
            else if (chemical1 == "Hydrochloric Acid" && chemical2 == "Sodium Hydroxide")
            {
                return "HCl(aq) + NaOH(aq) → NaCl(aq) + H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Oxygen" && chemical2 == "Hydrogen")
            {
                return "2 H₂(g) + O₂(g) → 2 H₂O(l)\nName of the chemical reaction: Combustion of hydrogen";
            }
            else if (chemical1 == "Methane" && chemical2 == "Oxygen")
            {
                return "CH₄(g) + 2 O₂(g) → CO₂(g) + 2 H₂O(l)\nName of the chemical reaction: Combustion of methane";
            }
            else if (chemical1 == "Sulfuric Acid" && chemical2 == "Sodium Hydroxide")
            {
                return "H₂SO₄(aq) + 2 NaOH(aq) → Na₂SO₄(aq) + 2 H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Nitric Acid" && chemical2 == "Sodium Hydroxide")
            {
                return "HNO₃(aq) + NaOH(aq) → NaNO₃(aq) + H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Ethanol" && chemical2 == "Oxygen")
            {
                return "C₂H₅OH(l) + 3 O₂(g) → 2 CO₂(g) + 3 H₂O(l)\nName of the chemical reaction: Combustion of ethanol";
            }
            else if (chemical1 == "Acetone" && chemical2 == "Oxygen")
            {
                return "C₃H₆O(l) + 4 O₂(g) → 3 CO₂(g) + 3 H₂O(l)\nName of the chemical reaction: Combustion of acetone";
            }
            else if (chemical1 == "Ammonia" && chemical2 == "Oxygen")
            {
                return "4 NH₃(g) + 3 O₂(g) → 2 N₂(g) + 6 H₂O(l)\nName of the chemical reaction: Combustion of ammonia";
            }
            else if (chemical1 == "Carbon Dioxide" && chemical2 == "Water")
            {
                return "CO₂(g) + H₂O(l) → H₂CO₃(aq)\nName of the chemical reaction: Carbonation of water";
            }
            else if (chemical1 == "Methanol" && chemical2 == "Oxygen")
            {
                return "2 CH₃OH(l) + 3 O₂(g) → 2 CO₂(g) + 4 H₂O(l)\nName of the chemical reaction: Combustion of methanol";
            }
            else if (chemical1 == "Ethylene" && chemical2 == "Oxygen")
            {
                return "C₂H₄(g) + 3 O₂(g) → 2 CO₂(g) + 2 H₂O(l)\nName of the chemical reaction: Combustion of ethylene";
            }
            else if (chemical1 == "Propane" && chemical2 == "Oxygen")
            {
                return "C₃H₈(g) + 5 O₂(g) → 3 CO₂(g) + 4 H₂O(l)\nName of the chemical reaction: Combustion of propane";
            }
            else if (chemical1 == "Benzene" && chemical2 == "Oxygen")
            {
                return "C₆H₆(l) + 15 O₂(g) → 6 CO₂(g) + 3 H₂O(l)\nName of the chemical reaction: Combustion of benzene";
            }
            else if (chemical1 == "Ethylene Glycol" && chemical2 == "Oxygen")
            {
                return "C₂H₆O₂(l) + 3 O₂(g) → 2 CO₂(g) + 2 H₂O(l)\nName of the chemical reaction: Combustion of ethylene glycol";
            }
            else if (chemical1 == "Acetic Acid" && chemical2 == "Sodium Hydroxide")
            {
                return "CH₃COOH(aq) + NaOH(aq) → CH₃COONa(aq) + H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Butane" && chemical2 == "Oxygen")
            {
                return "2 C₄H₁₀(g) + 13 O₂(g) → 8 CO₂(g) + 10 H₂O(l)\nName of the chemical reaction: Combustion of butane";
            }
            else if (chemical1 == "Formic Acid" && chemical2 == "Sodium Hydroxide")
            {
                return "HCOOH(aq) + NaOH(aq) → HCOONa(aq) + H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Propylene" && chemical2 == "Oxygen")
            {
                return "C₃H₆(g) + 5 O₂(g) → 3 CO₂(g) + 3 H₂O(l)\nName of the chemical reaction: Combustion of propylene";
            }
            else if (chemical1 == "Acetic Acid" && chemical2 == "Ethanol")
            {
                return "CH₃COOH(aq) + C₂H₅OH(l) → CH₃COOC₂H₅(aq) + H₂O(l)\nName of the chemical reaction: Esterification";
            }
            else if (chemical1 == "Hydrogen Peroxide" && chemical2 == "Potassium Iodide")
            {
                return "H₂O₂(aq) + 2 KI(aq) → 2 H₂O(l) + I₂(aq) + 2 KOH(aq)\nName of the chemical reaction: Decomposition of hydrogen peroxide";
            }
            else if (chemical1 == "Hydrogen Peroxide" && chemical2 == "Manganese Dioxide")
            {
                return "2 H₂O₂(aq) → 2 H₂O(l) + O₂(g) + 2 MnO₂(s)\nName of the chemical reaction: Decomposition of hydrogen peroxide";
            }
            else if (chemical1 == "Ammonia" && chemical2 == "Hydrochloric Acid")
            {
                return "NH₃(g) + HCl(g) → NH₄Cl(s)\nName of the chemical reaction: Formation of ammonium chloride";
            }
            else if (chemical1 == "Acetic Acid" && chemical2 == "Calcium Carbonate")
            {
                return "2 CH₃COOH(aq) + CaCO₃(s) → Ca(CH₃COO)₂(aq) + CO₂(g) + H₂O(l)\nName of the chemical reaction: Acid-base reaction";
            }
            else if (chemical1 == "Hydrogen Peroxide" && chemical2 == "Sodium Thiosulfate")
            {
                return "2 H₂O₂(aq) + 2 Na₂S₂O₃(aq) → 2 Na₂SO₄(aq) + 2 H₂O(l) + O₂(g) + S(s)\nName of the chemical reaction: Decomposition of hydrogen peroxide";
            }
            else if (chemical1 == "Potassium Permanganate" && chemical2 == "Hydrochloric Acid")
            {
                return "2 KMnO₄(aq) + 16 HCl(aq) → 5 Cl₂(g) + 2 MnCl₂(aq) + 8 H₂O(l) + 2 KCl(aq)\nName of the chemical reaction: Redox reaction";
            }
            else if (chemical1 == "Copper(II) Sulfate" && chemical2 == "Sodium Hydroxide")
            {
                return "CuSO₄(aq) + 2 NaOH(aq) → Cu(OH)₂(s) + Na₂SO₄(aq)\nName of the chemical reaction: Precipitation reaction";
            }
            else if (chemical1 == "Sodium Hydroxide" && chemical2 == "Hydrogen Chloride")
            {
                return "NaOH(aq) + HCl(aq) → NaCl(aq) + H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Silver Nitrate" && chemical2 == "Sodium Chloride")
            {
                return "AgNO₃(aq) + NaCl(aq) → AgCl(s) + NaNO₃(aq)\nName of the chemical reaction: Precipitation reaction";
            }
            else if (chemical1 == "Potassium Hydroxide" && chemical2 == "Sulfuric Acid")
            {
                return "2 KOH(aq) + H₂SO₄(aq) → K₂SO₄(aq) + 2 H₂O(l)\nName of the chemical reaction: Neutralization reaction";
            }
            else if (chemical1 == "Calcium Hydroxide" && chemical2 == "Carbon Dioxide")
            {
                return "Ca(OH)₂(aq) + CO₂(g) → CaCO₃(s) + H₂O(l)\nName of the chemical reaction: Precipitation reaction";
            }
            else if (chemical1 == "Potassium Iodide" && chemical2 == "Lead Nitrate")
            {
                return "2 KI(aq) + Pb(NO₃)₂(aq) → 2 KNO₃(aq) + PbI₂(s)\nName of the chemical reaction: Precipitation reaction";
            }
            else if (chemical1 == "Sodium Carbonate" && chemical2 == "Calcium Chloride")
            {
                return "Na₂CO₃(aq) + CaCl₂(aq) → CaCO₃(s) + 2 NaCl(aq)\nName of the chemical reaction: Precipitation reaction";
            }
            else if (chemical1 == "Potassium Permanganate" && chemical2 == "Hydrogen Peroxide")
            {
                return "2 KMnO₄(aq) + 3 H₂O₂(aq) → 2 MnO₂(s) + 2 KOH(aq) + 2 H₂O(l) + 3 O₂(g)\nName of the chemical reaction: Redox reaction";
            }
            else if (chemical1 == "Copper(II) Sulfate" && chemical2 == "Zinc")
            {
                return "CuSO₄(aq) + Zn(s) → ZnSO₄(aq) + Cu(s)\nName of the chemical reaction: Single displacement reaction";
            }
            else if (chemical1 == "Ammonium Nitrate" && chemical2 == "Calcium Hydroxide")
            {
                return "2 NH₄NO₃(aq) + Ca(OH)₂(aq) → Ca(NO₃)₂(aq) + 2 NH₄OH(aq)\nName of the chemical reaction: Double displacement reaction";
            }
            else if (chemical1 == "Potassium Chloride" && chemical2 == "Silver Nitrate")
            {
                return "KCl(aq) + AgNO₃(aq) → AgCl(s) + KNO₃(aq)\nName of the chemical reaction: Precipitation reaction";
            }

            // No match found
            return null;
        }

        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void pre_Click2(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
    }

    public class Chemical
    {
        public string Name { get; set; }
    }

    // RelayCommand class for handling commands
    public class RelayCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public RelayCommand(Action execute, Func<bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute();
        }

        public void Execute(object parameter)
        {
            _execute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }

    // RelayCommand class for handling commands with parameters
    public class RelayCommand<T> : ICommand
    {
        private readonly Action<T> _execute;
        private readonly Func<T, bool> _canExecute;

        public RelayCommand(Action<T> execute, Func<T, bool> canExecute = null)
        {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute((T)parameter);
        }

        public void Execute(object parameter)
        {
            _execute((T)parameter);
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
      
    }
}
