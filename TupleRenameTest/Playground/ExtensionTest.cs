using System;

namespace MultiTarget.Playground
{
    public static class ExtensionTest
    {
        public static (string Surname, int DeathAge) TupleExtensionMethod(
            this (string Name, int Age) parameter)
        {
            return (parameter.Name + "Son", parameter.Age + 1);
        }
    }

    public class PersonWithRealName
    {
        public readonly (string Name, int Age) Person;

        public PersonWithRealName((string Name, int Age) person)
        {
            this.Person = person;
        }

        private string GetSurname()
        {
            return ExtensionTest.TupleExtensionMethod(this.Person).Surname;
        }
    }

    public class PersonWithNickName
    {
        public readonly (string Name, int Age) Person;

        public PersonWithNickName(PersonWithRealName personWithRealName)
        {
            this.Person = (personWithRealName.Person.Name + "beaver", personWithRealName.Person.Age);
        }

        private string GetSurname()
        {
            return ExtensionTest.TupleExtensionMethod(this.Person).Surname;
        }

        public string GetNickName()
        {
            return Person.Name;
        }
    }
}