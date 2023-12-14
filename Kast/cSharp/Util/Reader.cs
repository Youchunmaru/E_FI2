
using System.Numerics;

namespace Util
{
/**
<summary>
    The <c>Reader</c> class implemens some helpful functions for reading the console.
    It provides simple <c>String</c> reading, but can also read and parse <c>INumber</c>s.
    Additional functionality is provided by the <c>msg overloading</c> ( which prints an input text before reading)
    or the <c>MultiRead</c> methods provide you with a short cut to read multiple inputs.
</summary>
<remarks>
    Author: Samuel Gröner \
    Version: 1.0.2311-2
</remarks>
*/
static class Reader{
    /**
    <summary>
    Basicly <c>Console.ReadLine()</c> but without null return.
    </summary>
    <returns>read String or if null empty String</returns>
    */
    public static String Read(){
        return Console.ReadLine() ?? string.Empty;
    }
    /**
    <summary>
    Prints <paramref name="msg"/> before reading line.
    </summary>
    <param name="msg">a text that lets the user know what to input</param>
    <returns>read String or if null empty String</returns>
    */
    public static String Read(String msg){
        return MsgPrinter<String>(msg,Read);
    }
    /**
    <summary>
    Reads the input and converts it to the specified <see cref="INumber"/> type.
    </summary>
    <typeparam name="T">an <see cref="INumber"/> type</typeparam>
    <returns> parsed input or default of T</returns>
    <remarks>You have to handle non <see cref="INumber"/> conform inputs yourself.</remarks>
    */
    public static T? NumericRead<T>() where T: INumber<T>{
        try {
            return T.Parse(Read(),null);
        }catch (Exception){
            return default;
        }
    }
    /**
    <summary>
    Prints <paramref name="msg"/> before reading line.
    Reads the input and converts it to the specified <see cref="INumber"/> type.
    </summary>
    <param name="msg">a text that lets the user know what to input</param>
    <typeparam name="T">an <see cref="INumber"/> type</typeparam>
    <returns> parsed input or default of T</returns>
    <remarks>You have to handle non <see cref="INumber"/> conform inputs yourself.</remarks>
    */
    public static T? NumericRead<T>(String msg) where T: INumber<T> {
        return MsgPrinter<T>(msg,NumericRead<T>);;
    }
    /**
    <summary>
    Reads the input and converts it to the specified <see cref="INumber"/> type.
    </summary>
    <typeparam name="T">an <see cref="INumber"/> type</typeparam>
    <returns> parsed input</returns>
    <remarks>Handles non <see cref="INumber"/> conform inputs by recursev return.</remarks>
    */
    public static T TryNumericRead<T>() where T: INumber<T>{
        T t = T.Zero;
        while (!T.TryParse(Read(), null, out t))
        {
            Console.WriteLine("\nERROR: Coudnt parse literal! (Exit with ctrl + c)\n");
        }
        return t;
    }
    /**
    <summary>
    Prints <paramref name="msg"/> before reading line.
    Reads the input and converts it to the specified <see cref="INumber"/> type.
    </summary>
    <param name="msg">a text that lets the user know what to input</param>
    <typeparam name="T">an <see cref="INumber"/> type</typeparam>
    <returns> parsed input</returns>
    <remarks>Handles non <see cref="INumber"/> conform inputs by recursev return.</remarks>
    */
    public static T TryNumericRead<T>(String msg) where T: INumber<T> {
        return MsgPrinter<T>(msg,TryNumericRead<T>);
    }
    /**
    <summary>
    Reads <paramref name="count"/> inputs and converts them to the specified <see cref="INumber"/> type.
    </summary>
    <param name="count">number of inputs</param>
    <typeparam name="T">an <see cref="INumber"/> type</typeparam>
    <returns> parsed inputs</returns>
    <remarks>Handles non <see cref="INumber"/> conform inputs by recursev return.</remarks>
    */
    public static T[] MultiRead<T>(int count) where T: INumber<T>{
        return NumericMultiRead<T>(new String[count]);
    }
    /**
    <summary>
    For every msg of <paramref name="msgs"/>.
    Prints msg before reading a line.
    Reads the input and converts it to the specified <see cref="INumber"/> type.
    </summary>
    <param name="msgs">texts that lets the user know what to input</param>
    <typeparam name="T">an <see cref="INumber"/> type</typeparam>
    <returns> parsed inputs</returns>
    <remarks>Handles non <see cref="INumber"/> conform inputs by recursev return.</remarks>
    */
    public static T[] NumericMultiRead<T>(params String[] msgs) where T: INumber<T>{
        T[] inputs = new T[msgs.Length];
        for (int i = 0; i < msgs.Length; i++){
            inputs[i] = TryNumericRead<T>(msgs[i]);
        }
        return inputs;
    }
    /**
    <summary>
    Reads <paramref name="count"/> inputs.
    </summary>
    <param name="count">number of inputs</param>
    <returns> read lines or empty Strings if null</returns>
    <remarks>Handles non <see cref="INumber"/> conform inputs by recursev return.</remarks>
    */
    public static String[] MultiRead(int count){
        return MultiRead(new String[count]);
    }
    /**
    <summary>
    For every msg of <paramref name="msgs"/>.
    Prints msg before reading a line.
    </summary>
    <param name="msgs">texts that lets the user know what to input</param>
    <returns> read lines or empty Strings if null</returns>
    */
    public static String[] MultiRead(params String[] msgs){
        String[] inputs = new string[msgs.Length];
        for (int i = 0; i < msgs.Length; i++){
            inputs[i] = Read(msgs[i]);
        }
        return inputs;
    }
    /**
    <summary>
    Print helper method.
    </summary>
    <param name="msg">text that lets the user know what to input</param>
    <param name="func">the method that reads the line</param>
    <returns> return of <paramref name="func"/></returns>
    */
    private static T MsgPrinter<T>(String msg, Func<T> func){
        Console.Write(msg);
        T input = func();
        Console.WriteLine();
        return input;
    }
}
}