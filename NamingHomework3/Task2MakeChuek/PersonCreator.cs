namespace Task2MakeChuek
{
    using Task2MakeChuek.Enumerations;

    public class PersonCreator
    {
        public void CreatePerson(int personIdentifier)
        {
            Person newPerson = new Person();
            newPerson.Age = personIdentifier;

            if (personIdentifier % 2 == 0)
            {
                newPerson.Name = "Батката";
                newPerson.Sex = PersonSex.CoolGay;
            }
            else
            {
                newPerson.Name = "Мацето";
                newPerson.Sex = PersonSex.Playmate;
            }
        }

        public class Person
        {
            public PersonSex Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }
    }
}
