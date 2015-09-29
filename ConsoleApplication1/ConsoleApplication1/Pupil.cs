using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    // le ":" signifie que la classe Pupil hérite de la classe Person
    public class Pupil : Person
    {
        private int grade;
        public int Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        private List<Activity> lstActivities;
        public List<Activity> LstActivities
        {
            get { return lstActivities; }
            set { lstActivities = value; }
        }

        private char[] tabEval;
        public char[] TabEval
        {
            get { return tabEval; }
            set { tabEval = value; }
        }

        public Pupil(String name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();           
            TabEval = new char[Parameter.nbMaxAct];
        }

        public Pupil(String name, int age)
            : this(name, age, 1)
        {

        }

        public void AddActivity(Activity act)
        {
            LstActivities.Add(act);
        }

        public override string ToString()
        {
            string ch = base.ToString() +
            ((LstActivities.Count() != 0) ? " a choisi " : "n’a pas encore choisi d’activité");

            int i;
            for (i = 0; i < LstActivities.Count(); i++)
            {
                ch += "\n " + LstActivities[i];
            }
            return ch;
        }

        public void AddEvaluation(String title = null, char evaluation = 'S')
        {
            int i = 0;
            if (title != null)
            {
                foreach (Activity activity in lstActivities)
                {
                    if (activity.Title.Equals(title)) break;
                    i++;
                }
                lstActivities.Add(new Activity(title, true));
                TabEval[i] = evaluation;
            }
        }

        public char GetEvaluationFor(String title)
        {
            int i = 0;
            if (title != null)
            {
                foreach (Activity activity in lstActivities)
                {
                    if (activity.Title.Equals(title))
                        return TabEval[i];
                }
            }
            throw new ArgumentNullException("title");
        }
    }
}
