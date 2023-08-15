namespace MyCalculator.Classes
{
    public class AdvancedCalculatoR : CalculatoR
    {
        bool isRepeat = false;
        public override void Calculate()
        {
            base.Calculate();

            Console.WriteLine("Do you want to enable advanced calculator? [y/n]: ");
            string answer = Console.ReadLine();

            isRepeat = answer == "y" ? true : false;
            if(answer == "y")
            {
                Operation = ValueManipulator.GetUserValueFromMessage("Operations\n1) √a  \n2) a^b ");
                if(Operation == "1") 
                {
                   FirstValue = ValueManipulator.GetUserValueFromMessage("Enter Values\nEnter number a: ");
                    
                }
                else if(Operation == "2")
                {
                  FirstValue = ValueManipulator.GetUserValueFromMessage("Enter Values\nEnter number a: ");
                  SecondValue = ValueManipulator.GetUserValueFromMessage("Enter power number a: ");

                }
                ReporteR.RepotProgress("Converting values...");

                FirsNumber = ValueManipulator.ConvertUserValueToDecimal(FirstValue);
                SecondNumber = ValueManipulator.ConvertUserValueToDecimal(SecondValue);

                //string template = $"{FirsNumber} {Operation} {SecondNumber} =";
                double result = decimal.Parse(Operation) switch
                {
                    1 => SqeareRoot(FirsNumber),
                    2 => Caret(FirsNumber, SecondNumber),
                    _ => 0
                };

                if (Operation == "1")
                {
                    ReporteR.RepotResult($"√{FirsNumber} = {result}");

                }
                else if (Operation == "2")
                {
                    ReporteR.RepotResult($"{FirsNumber}^{SecondNumber}  = {result}");

                }
                
            }


        }


        public double SqeareRoot(decimal number)
        {
            return Math.Sqrt((double)number);
        } 
        public double Caret(decimal number,  decimal power)
        {
            return Math.Pow((double)number, (int)power);
        }

    }
}