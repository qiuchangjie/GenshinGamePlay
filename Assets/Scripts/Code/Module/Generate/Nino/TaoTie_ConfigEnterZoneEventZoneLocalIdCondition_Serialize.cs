/* this is generated by nino */
namespace TaoTie
{
    public partial class ConfigEnterZoneEventZoneLocalIdCondition
    {
        public static ConfigEnterZoneEventZoneLocalIdCondition.SerializationHelper NinoSerializationHelper = new ConfigEnterZoneEventZoneLocalIdCondition.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ConfigEnterZoneEventZoneLocalIdCondition>
        {
            #region NINO_CODEGEN
            public override void Serialize(ConfigEnterZoneEventZoneLocalIdCondition value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.CompressAndWriteEnum<TaoTie.CompareMode>(value.mode);
                writer.CompressAndWrite(ref value.value);
            }

            public override ConfigEnterZoneEventZoneLocalIdCondition Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                ConfigEnterZoneEventZoneLocalIdCondition value = new ConfigEnterZoneEventZoneLocalIdCondition();
                reader.DecompressAndReadEnum<TaoTie.CompareMode>(ref value.mode);
                reader.DecompressAndReadNumber<System.Int32>(ref value.value);
                return value;
            }
            #endregion
        }
    }
}