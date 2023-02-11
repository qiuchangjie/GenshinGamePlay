/* this is generated by nino */
namespace TaoTie
{
    public partial class ConfigGearAndAction
    {
        public static ConfigGearAndAction.SerializationHelper NinoSerializationHelper = new ConfigGearAndAction.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ConfigGearAndAction>
        {
            #region NINO_CODEGEN
            public override void Serialize(ConfigGearAndAction value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.Write(value.disable);
                writer.CompressAndWrite(ref value.localId);
                writer.Write(value.isOtherGear);
                writer.CompressAndWrite(ref value.otherGearId);
                writer.Write(value.conditions);
                writer.Write(value.success);
                writer.Write(value.fail);
            }

            public override ConfigGearAndAction Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                ConfigGearAndAction value = new ConfigGearAndAction();
                reader.Read<System.Boolean>(ref value.disable, 1);
                reader.DecompressAndReadNumber<System.Int32>(ref value.localId);
                reader.Read<System.Boolean>(ref value.isOtherGear, 1);
                reader.DecompressAndReadNumber<System.UInt64>(ref value.otherGearId);
                value.conditions = reader.ReadArray<TaoTie.ConfigGearCondition>();
                value.success = reader.ReadArray<TaoTie.ConfigGearAction>();
                value.fail = reader.ReadArray<TaoTie.ConfigGearAction>();
                return value;
            }
            #endregion
        }
    }
}