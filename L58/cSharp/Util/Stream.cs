
namespace Util{
    /// <summary>
    /// The <c>Stream<c/> class provides extension functions to stream arrays.
    /// It provides functions for manipulating, rebuilding and accessing the items of the array.
    /// </summary>
    /// <remarks>
    /// Author: Samuel Gröner \
    /// Version: 1.0.2401-4
    /// </remarks>
    static class Stream
    {
        /// <summary>
        /// Performs the given action on the contents of the array.
        /// </summary>
        /// <typeparam name="T">the type of this</typeparam>
        /// <param name="collection">the array of this</param>
        /// <param name="action">forEach function</param>
        public static void ForEach<T>(this IEnumerable<T> collection, Action<T> action){
            foreach (var item in collection)
            {
                action(item);
            }
        }
        /// <summary>
        /// Generates a acsending sequence of numbers to perform a action on.
        /// </summary>
        /// <param name="start">The start of the sequence included</param>
        /// <param name="end">the end of the sequence excluded</param>
        /// <param name="action">the action to perform on the sequenced position</param>
        /// <param name="step">the step size</param>
        public static void Sequence(int start, int end, Action<int> action, int step = 1){
            for (int i = start; i < end ; i++){
                action(i);
                i += step - 1;
            }
        }
        /// <summary>
        /// Generates a desending sequence of numbers to perform a action on.
        /// </summary>
        /// <param name="start">The start of the sequence included</param>
        /// <param name="end">the end of the sequence excluded</param>
        /// <param name="action">the action to perform on the sequenced position</param>
        /// <param name="step">the step size</param>
        public static void SequenceReversed(int start, int end, Action<int> action, int step = 1){
            for (int i = start; i > end ; i--){
                action(i);
                i -= step - 1;
            }
        }
        /// <summary>
        /// Performs a action on a sequence of this items.
        /// </summary>
        /// <typeparam name="T">the type of this</typeparam>
        /// <param name="collection">the enumerable of this</param>
        /// <param name="end">the end of the sequence excluded</param>
        /// <param name="action">the action to perform on the sequenced item</param>
        /// <param name="start">the start of the sequence included</param>
        /// <param name="step">the step size</param>
        public static void Sequence<T>(this IEnumerable<T> collection, int end, Action<T> action, int start = 0, int step = 1){
            int index = 0;
            int stepper = 0;
            foreach(var item in collection){
                if(stepper == 0 && start <= index && index < end){
                    action(item);
                    stepper = step;
                }
                index++;
                stepper--;
            }
        }

        public static void Modify<T>(this T item, Action<T> modifier){
            modifier(item);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="modifier"></param>
        public static void Modify<T>(this T[] collection, Action<T> modifier){
            for(int i = 0; i < collection.Count(); i++){
                collection[i].Modify(modifier);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="modifier"></param>
        /// <param name="end"></param>
        /// <param name="start"></param>
        /// <param name="step"></param>
        public static void ModifySequence<T>(this T[] collection, Action<T> modifier, int end, int start = 0, int step = 1){
            for (int i = start; i < end ; i++){
                collection[i].Modify(modifier);
                i += step - 1;
            }
        }
    }
}