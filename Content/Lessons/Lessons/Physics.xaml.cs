using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lessons
{
    /// <summary>
    /// Interaction logic for Physics.xaml
    /// </summary>
    public partial class Physics : Window
    {
        private int currentConceptIndex = 0;

        private readonly string[] physicsConcepts = {
            "Newton's First Law: An object at rest stays at rest, and an object in motion stays in motion with the same speed and in the same direction unless acted upon by an unbalanced external force.",
            "Newton's Second Law: The acceleration of an object is directly proportional to the net force acting upon the object and inversely proportional to the object's mass.",
            "Newton's Third Law: For every action, there is an equal and opposite reaction.",
            "Gravity: The force that attracts two objects toward each other. It gives weight to physical objects and is responsible for the orbits of planets around the sun.",
            "Magnetism: The force exerted by magnets. Like poles repel each other, and opposite poles attract.",
            "Friction: The force resisting the relative motion or tendency of motion of two surfaces in contact.",
            "Buoyancy: The upward force exerted by a fluid (liquid or gas) that opposes the weight of an immersed object.",
            "Light: Travels in straight lines and can be reflected, refracted, or absorbed.",
            "Sound: Travels in waves through a medium (such as air or water) and requires a medium to propagate.",
            "Electricity: The flow of electric charge. It can produce light, heat, and magnetism.",
            "Inertia: The tendency of an object to resist changes in its state of motion.",
            "Centripetal Force: The force that keeps an object moving in a circular path.",
            "Pressure: Force applied per unit area. Pressure increases with force or decreases with area.",
            "Kinetic Energy: The energy an object possesses due to its motion.",
            "Potential Energy: The stored energy an object has due to its position or state.",
            "Work: The product of force and the distance over which the force is applied.",
            "Power: The rate at which work is done or the rate at which energy is transferred.",
            "Heat Transfer: The movement of thermal energy between objects of different temperatures.",
            "Wave: A disturbance that travels through space, transferring energy from one point to another.",
            "Optics: The study of light and its interactions with matter."
        };

        public Physics()
        {
            InitializeComponent();
            ShowConcept();
        }

        private void ShowConcept()
        {
            contentTextBlock.Text = physicsConcepts[currentConceptIndex];
        }

        private void NextConcept_Click(object sender, RoutedEventArgs e)
        {
            currentConceptIndex++;
            if (currentConceptIndex >= physicsConcepts.Length)
            {
                MessageBox.Show("Congratulations! You've learned some basic physics concepts.", "Finished");
                Close();
            }
            else
            {
                ShowConcept();
            }
        }

        private void pre_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Visibility = Visibility.Visible;
            this.Close();
        }
    }
}
