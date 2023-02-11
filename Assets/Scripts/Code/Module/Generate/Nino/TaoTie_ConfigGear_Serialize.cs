/* this is generated by nino */
namespace TaoTie
{
    public partial class ConfigGear
    {
        public static ConfigGear.SerializationHelper NinoSerializationHelper = new ConfigGear.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ConfigGear>
        {
            #region NINO_CODEGEN
            public override void Serialize(ConfigGear value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.CompressAndWrite(ref value.id);
                writer.Write(value.actors);
                writer.Write(value.zones);
                writer.Write(value.triggers);
                writer.Write(value.group);
                writer.Write(value.route);
                writer.Write(value.randGroup);
                writer.CompressAndWrite(ref value.initGroup);
            }

            public override ConfigGear Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                ConfigGear value = new ConfigGear();
                reader.DecompressAndReadNumber<System.UInt64>(ref value.id);
                value.actors = reader.ReadArray<TaoTie.ConfigGearActor>();
                value.zones = reader.ReadArray<TaoTie.ConfigGearZone>();
                value.triggers = reader.ReadArray<TaoTie.ConfigGearTrigger>();
                value.group = reader.ReadArray<TaoTie.ConfigGearGroup>();
                value.route = reader.ReadArray<TaoTie.ConfigRoute>();
                reader.Read<System.Boolean>(ref value.randGroup, 1);
                reader.DecompressAndReadNumber<System.Int32>(ref value.initGroup);
                return value;
            }
            #endregion
        }
    }
}