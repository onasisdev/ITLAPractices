using System.Reflection.Metadata;

namespace FirstTask
{
    public class Program
    {
        static void Main(string[] args)

        {
            //1. Profesor de Historia:
            Persona historyProfessor = new Persona("Carlos", "Almonte", 36, false, "890-44347-09-3");
            historyProfessor.HistoryProfessorAction();

            //2. Odontólogo:
            Persona dentist = new Persona("Alejandro", "Hughes", 30, true, "110-41387-03-2");
            dentist.DentistAction();

            //3. Psicólogo
            Persona psychologist = new Persona("Pedro", "Pereyra", 40, false, "120-51317-01-7");
            psychologist.PsychologistAction();

            //4. Ingeniero Mecánico
            Persona mechanicalEng = new Persona("Jose", "Perez", 32, true, "190-13312-01-4");
            mechanicalEng.MechanicalEngAction();

            //5. Ingeniero Civil
            Persona civilEng = new Persona("Alexander", "Jiménez", 27, false, "130-12812-01-1");
            civilEng.CivilEngAction();

            //6. Ingeniero Eléçtrico
            Persona electricalEng = new Persona("Adrián", "Henríquez", 25, true, "900-18219-01-2");
            electricalEng.ElectricalEngAction();

            //7. Ingeniero Químico
            Persona chemicalEng = new Persona("Gonzalo", "Aponte", 28, false, "490-16332-01-4");
            chemicalEng.ChemicalEngAction();


            Console.ReadKey();
        }
    }

    public class Persona { 
        public string name;
        public string lastname;
        public int age;
        public bool married;
        public string identityDocumentNumber;

        public Persona (string name, string lastname, int age, bool married, string identityDocumentNumber)
        {
            this.name = name;
            this.lastname = lastname;
            this.age = age;
            this.married = married;
            this.identityDocumentNumber = identityDocumentNumber;
        }

        public void HistoryProfessorAction()
        {
            Console.WriteLine($"""
            El Profesor de historia {name} {lastname} de {age} años de edad
            va a dar una introducción a la materia Historia Universal.

            """);
        }

        public void DentistAction()
        {
            Console.WriteLine($"""
            El Odóntologo {name} {lastname} de {age} años de edad 
            va a chequearle una muela a un paciente.

            """);
        }

        public void PsychologistAction()
        {
            Console.WriteLine($"""
            El Psicólogo {name} {lastname} de {age} años de edad 
            va a realizar una terapia familiar.

            """);
        }

        public void MechanicalEngAction()
        {
            Console.WriteLine($"""
            El Ingeniero Mecánico {name} {lastname} de {age} años de edad 
            va a diseñar una pieza para un robot.

            """);
        }

        public void CivilEngAction()
        {
            Console.WriteLine($"""
            El Ingeniero Civil {name} {lastname} de {age} años de edad 
            va a diseñar una carretera.

            """);
        }

        public void ElectricalEngAction()
        {
            Console.WriteLine($"""
            El Ingeniero Eléctrico {name} {lastname} de {age} años de edad 
            va a evaluar unos equipos electrónicos.

            """);
        }

        public void ChemicalEngAction()
        {
            Console.WriteLine($"""
            El Ingeniero Químico {name} {lastname} de {age} años de edad 
            va a producir nuevos fármacos.
            """);
        }
    }
}
