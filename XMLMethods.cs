using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GuitarExercises
{
    public class xmlMethods
    {
        public static void InsertObject(ExerciseObject obj)
        {
        
            XmlSerializer serializer = new XmlSerializer(typeof(List<ExerciseObject>));

            bool dataExists = File.Exists("myExercises.xml");

            // Declare an object variable of the type to be deserialized.
            List<ExerciseObject> data = new List<ExerciseObject>();

            if (dataExists)
            {
                // A FileStream is needed to read the XML document.
                FileStream fs = new FileStream("myExercises.xml", FileMode.Open);

                /* Use the Deserialize method to restore the object's state with
                data from the XML document. */
                data = (List<ExerciseObject>)serializer.Deserialize(fs);

                fs.Close();
            }

            data.Add(obj);

            TextWriter writer = new StreamWriter("myExercises.xml");
            serializer.Serialize(writer, data);
            writer.Close();

        }

        public static int NextIndex(List<ExerciseObject> list)
        {
            int toReturn = list.Count;
            return toReturn;
        }

        public static ExerciseObject GetRandom()
        {
            

            XmlSerializer serializer = new XmlSerializer(typeof(List<ExerciseObject>));

            
            FileStream fs = new FileStream("myExercises.xml", FileMode.Open);
            

            // Declare an object variable of the type to be deserialized.
            List<ExerciseObject> data = new List<ExerciseObject>();

            /* Use the Deserialize method to restore the object's state with
            data from the XML document. */
            data = (List<ExerciseObject>)serializer.Deserialize(fs);

            fs.Close();

            var rand = new Random();

            int ranIndex = rand.Next(data.Count);

            ExerciseObject toReturn = data.ElementAt(ranIndex);

            return toReturn;

        }

        public static void UpdateExisting(ExerciseObject currentItem)
        {
            //Read DB File
            XmlSerializer serializer = new XmlSerializer(typeof(List<ExerciseObject>));
            FileStream fs = new FileStream("myExercises.xml", FileMode.Open);
            // Declare an object variable of the type to be deserialized.
            List<ExerciseObject> data = new List<ExerciseObject>();
            /* Use the Deserialize method to restore the object's state with
            data from the XML document. */
            data = (List<ExerciseObject>)serializer.Deserialize(fs);
            fs.Close();

            foreach (ExerciseObject thingie in data)
            {
                if (thingie.NameOfExercise.Equals(currentItem.NameOfExercise))
                {
                    thingie.Tempo = currentItem.Tempo;
                    thingie.Description = currentItem.Description;
                }
            }

            //update db file
            TextWriter writer = new StreamWriter("myExercises.xml");
            serializer.Serialize(writer, data);
            writer.Close();



        }

    }

    
     

}















