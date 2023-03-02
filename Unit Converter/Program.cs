using Unit_Converter;
using static Unit_Converter.Measurements;
using static Unit_Converter.Converter;

Measurements measurement = new();
Converter converter = new();


Console.WriteLine("Please click the number of the measurement you'd like to convert from: \n1) Meter \n2) Kilometer \n3) Centimeter  \n4) Millimeter \n5) Mile \n6) Yard \n7) Foot \n8) Inch \n9) Light Year");
int convertFrom = Int32.Parse(Console.ReadLine());

string typeFrom = measurement.GetMeasurementType(convertFrom);
Console.WriteLine($"you chose {typeFrom}");

Console.WriteLine("Now please click the number of the measurement you'd like to convert into: \n1) Meter \n2) Kilometer \n3) Centimeter  \n4) Millimeter \n5) Mile \n6) Yard \n7) Foot \n8) Inch \n9) Light Year");

int convertTo = Int32.Parse(Console.ReadLine());

string typeTo = measurement.GetMeasurementType(convertTo);

Console.WriteLine($"you chose {typeTo}");    // string of type


Console.Write("Please enter the value you would like to convert. The value must be a whole number.");

int value = Convert.ToInt32(Console.ReadLine());

int result = (int)converter.UnitConvert(typeFrom, typeTo, value);

Console.WriteLine($"{value} {typeFrom} = {result} {typeTo}"); 

//Console.WriteLine(value);










//Console.WriteLine(converter.ConvertUnit(typeFrom, typeTo));