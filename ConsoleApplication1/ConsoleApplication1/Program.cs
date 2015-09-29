using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(String [] args)
        {
            List<Pupil> lstPupils = new List<Pupil>()
            {             
                // Création Elèves            
                new Pupil("Julien",21,3),
                new Pupil("Loïc", 8,1),
                new Pupil("Mélanie", 12,3),
                new Pupil("Arthur", 11,3),
                new Pupil("Coralie", 7,1),
                new Pupil("Nicolas", 9,2)
            };

            List<Pupil> lstPupilsDuplicated = new List<Pupil>()
            {             
                        
                new Pupil("Julien",21,3),
                new Pupil("Loïc", 8,1),
                new Pupil("Coralie", 7,1),
                new Pupil("Arthur", 11,3),
                new Pupil("Coralie", 7,1),
                new Pupil("Julien",21,3)
            };

            List<Person> lstPersons = new List<Person>()
            {
                new Person("Jean",56),
                new Person("Alison",18),
                new Person("Céline",24)
            };

            var listFusion = lstPersons.Union(lstPupils);

            foreach(var fusion in listFusion)
            {
                //Console.WriteLine(fusion.Name);
            }
            /*
            // Ajout Elèves dans la liste
            lstPupils.Add(p1);
            lstPupils.Add(p2);
            lstPupils.Add(p3);
            lstPupils.Add(p4);
            lstPupils.Add(p5);
            lstPupils.Add(p6);
                    
            // Création Variable Anonyme           
            

            // Création Activités
            Activity a1 = new Activity("Mathématiques", true);
            Activity a2 = new Activity("Français", true);
            Activity a3 = new Activity("Géographie", false);

            
            // Ajout Activités
            p1.AddActivity(a1);
            p1.AddActivity(a2);
            p1.AddActivity(a3); 

            // Ajout Evaluations
            p1.AddEvaluation("Mathématiques");
            p1.AddEvaluation(evaluation: Parameter.tresBon, title: "Histoire");
            p1.AddEvaluation("Français",Parameter.recommencer);*/

            // Variable Anonyme            
            /*var pupilGrade1Plus6 = from Pupil in lstPupils
                                   where Pupil.Grade == 1 && Pupil.Age >= 6
                                   select Pupil;*/
            var pupilGrade1Plus6 = lstPupils.Where(Pupil => Pupil.Age >= 6 && Pupil.Grade == 1);
            
            if (pupilGrade1Plus6 != null)
            {
                foreach (var pupil in pupilGrade1Plus6)
                {                    
                    //Console.WriteLine(pupil.Name);
                }
            }
            else
            {
                Console.WriteLine("pupil Vide !!! ");
            }

            // Commandes Console
            //Console.WriteLine(p1.ToString());
            Console.ReadKey();


            IEnumerable<Pupil> listPupilsNoDuplicated = lstPupilsDuplicated.Distinct<Pupil>
                (new PersonComparer());
           

           
        }   
    }
}
