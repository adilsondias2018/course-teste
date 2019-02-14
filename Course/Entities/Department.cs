

namespace Course.Entities
{
    class Department
    {

        public string Name { get; set; }


        // Construtor genérico que recebe o que tiver ou nada

        public Department()
        {

        }

        // sobrecarga do construtor com o construtor nome
        public Department(String name)
        {
            Name = name;
        }


    }
}
