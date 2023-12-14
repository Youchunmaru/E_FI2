using Util;
namespace DataTypes {
public class KartonProjekt {

    public static void RunAll(){
        Console.WriteLine("---DataTypes: Karton Project---");
        //Karton input bcd
        Console.WriteLine("Please enter Karton dimensons: ");
        float lenght = Reader.TryNumericRead<float>("length: ");
        float width = Reader.TryNumericRead<float>("width: ");
        float hight = Reader.TryNumericRead<float>("hight: ");
        
        Karton karton = new Karton(lenght, width, hight);
        Console.WriteLine(karton);
        //f = ?
        //Person input gh
        String firstName = "Max";
        String lastName = "Mustermann";
        Console.WriteLine("Please enter Person data: ");
        int age = Reader.TryNumericRead<int>("age: ");
        String adress = Reader.Read("adress: ");

        Person person = new Person(firstName,lastName,age,adress);
        Console.WriteLine(person);
        
        Console.WriteLine(true);//i

        //Chips Input j
        Chips chips = new Chips(0.99,350);
        double secondSize = 950;
        Console.WriteLine("According to {0}\n the price for {1} should be {2:0.00}", chips, secondSize, chips.CalculatePriceFromSize(secondSize));

        //k
        int first = 2000000000;
        int second = 2000000000;
        int third = first + second;
        Console.WriteLine(third);

        //l
        float lFloat = 10.0f - 9.9f;
        double lDouble = 10.0 - 9.9;
        decimal lDecimal = 10.0m - 9.9m;
        System.Console.WriteLine(lFloat + "|" + lDouble + "|" + lDecimal);

        //2
        Console.WriteLine("Text\bText\bText");
        Console.WriteLine("\"C:\\Programme...\"");
        Console.WriteLine("?\a?");

        //puffer
        Karton secondKarton = new Karton(100,10,1);
        //NP-problem (nondeterministic polynomial): implementing a solution for this problem is way to complex for this lecture, so i did this
        //naive solution
        Console.WriteLine("The karton {0}\n fits {1} times in {2}",secondKarton,karton.CalculateNumberFittingInside(secondKarton),karton);
        //after i realized there are three axis you can turn your karton on i implemended this
        Console.WriteLine("The karton {0}\n fits {1} times in {2}",secondKarton,karton.CalculateNumberFittingInsideRotation(secondKarton),karton);
    }

    private class Chips{// j
        private readonly double _price;
        private readonly double _size;

        public Chips(double price, double size){
            _price = price;
            _size = size;
        }

        public double CalculatePriceFromSize(double secondSize){
            return _price/_size * secondSize;
        }

        override
        public String ToString(){
            return "{\n"
                + "size: " + _size + "\n"
                + "price: " + _price +"\n}";
        }

    }
    private class Person{// gh
        private readonly String _firstName;
        private readonly String _lastName;
        private readonly int _age;
        private readonly String _adress;

        public Person(String firstName, String lastName, int age, String adress){
            _firstName = firstName;
            _lastName = lastName;
            _age = age;
            _adress = adress;
        }

        override
        public String ToString()
        { 
            return "{\nfirstName: " + _firstName + "\n"
                + "lastname: " + _lastName + "\n"
                + "age: " + _age + "\n"
                + "adress: " + _adress + "\n}";
        }
    }
    private class Karton{
        
        private readonly float _length;
        private readonly float _width;
        private readonly float _hight;

        private readonly int[] _fits = new int[8];
        private int _count = 0;

        public Karton(float lenght, float width, float hight){
            _length = lenght;
            _width = width;
            _hight = hight;
        }

        private double CalculateArea(){//b)
            return _length*_width;
        }

        private double CalculateVolume(){//c)
            return CalculateArea() * _hight;
        }

        private double CalculateCircumfrence(){//d)
            return (_width + _length) * 2;
        }
        //returns false values eg: 3/2/1 in 1/2/3
        //doent fit because 3 > 1
        //but if you turn the karton around it fits
        public int CalculateNumberFittingInside(Karton karton){
            int lengthNumber = (int) (_length/karton._length);
            int widthNumber = (int) (_width/karton._width);
            int hightNumber = (int) (_hight/karton._hight);
            return lengthNumber >= 1 && widthNumber >= 1 && hightNumber >= 1 ?
            lengthNumber * widthNumber * hightNumber : 0;
        }

        public int CalculateNumberFittingInsideRotation(Karton karton){
            //you dont have to sort them but i was to lazy to put them in an array
            float[] firstDimensions = {_length,_width,_hight};
            float[] secondDimensions = {karton._length,karton._width,karton._hight};

            _count = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 2; k++)
                    {
                        CheckFitting(firstDimensions,secondDimensions);
                        secondDimensions = SwapThird(secondDimensions);
                    }
                    secondDimensions = SwapSecond(secondDimensions);
                }
                secondDimensions = SwapFirst(secondDimensions);
            }
            Array.Sort(_fits);
            return _fits[7];
        }

        private void CheckFitting(float[] firstDimensions,float[] secondDimensions){
            int smallest = (int) (firstDimensions[0]/secondDimensions[0]);
            int middle = (int) (firstDimensions[1]/secondDimensions[1]);
            int biggest = (int) (firstDimensions[2]/secondDimensions[2]);
            _fits[_count++] = smallest >= 1 && middle >= 1 && biggest >= 1 ?
            smallest * middle * biggest : 0;
        }

        private float[] SwapFirst(float[] dimensions){
            float first = dimensions[0];
            float second = dimensions[1];

            dimensions[0] = second;
            dimensions[1] = first;

            return dimensions;
        }

        private float[] SwapSecond(float[] dimensions){
            float first = dimensions[0];
            float third = dimensions[2];

            dimensions[0] = third;
            dimensions[2] = first;

            return dimensions;
        }

        private float[] SwapThird(float[] dimensions){
            float second = dimensions[1];
            float third = dimensions[2];

            dimensions[1] = third;
            dimensions[2] = second;

            return dimensions;
        }
        
        override
        public String ToString(){//bcd)
            return "{\nlength: " + _length + "\n"
                + "width: " +_width + "\n"
                + "hight: " + _hight + "\n"
                + "area: " + CalculateArea() + "\n"
                + "Volume: " + CalculateVolume() + "\n"
                + "Circumfrence: " + CalculateCircumfrence() + "\n}";
                //"Circumfrence: {0}", CalculateCircumfrence()
        }
        
    }
}
}