/* this is generated by nino */
namespace TaoTie
{
    public partial class ConfigGroupLoadEventIsAddOnCondition
    {
        public static ConfigGroupLoadEventIsAddOnCondition.SerializationHelper NinoSerializationHelper = new ConfigGroupLoadEventIsAddOnCondition.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ConfigGroupLoadEventIsAddOnCondition>
        {
            #region NINO_CODEGEN
            public override void Serialize(ConfigGroupLoadEventIsAddOnCondition value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.CompressAndWriteEnum<TaoTie.CompareMode>(value.mode);
                writer.Write(value.value);
            }

            public override ConfigGroupLoadEventIsAddOnCondition Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                ConfigGroupLoadEventIsAddOnCondition value = new ConfigGroupLoadEventIsAddOnCondition();
                reader.DecompressAndReadEnum<TaoTie.CompareMode>(ref value.mode);
                reader.Read<System.Boolean>(ref value.value, 1);
                return value;
            }
            #endregion
        }
    }
}