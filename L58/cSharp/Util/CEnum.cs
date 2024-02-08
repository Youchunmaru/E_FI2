namespace Util {
    abstract class CEnum<T>{

        protected static readonly List<CEnumField<T>> cEnum = new();

        public CEnum(params CEnumField<T>[] enumValues){
            enumValues.ForEach(cEnum.Add);
        }

        public static CEnumField<T>? OfString(String key){
            return cEnum.Find((it) => it.GetKey().Equals(key.ToUpper()));
        }
    }

    class CEnumField<T>
    {
        private readonly String key;
        private readonly T value;
        public CEnumField(String key, T value){
            this.key = key;
            this.value = value;
        }
        public String GetKey(){
            return key;
        }

        public T GetValue(){
            return value;
        }
    }
}