/* this is generated by nino */
namespace TaoTie
{
    public partial class ConfigEnterZoneEventTrigger
    {
        public static ConfigEnterZoneEventTrigger.SerializationHelper NinoSerializationHelper = new ConfigEnterZoneEventTrigger.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ConfigEnterZoneEventTrigger>
        {
            #region NINO_CODEGEN
            public override void Serialize(ConfigEnterZoneEventTrigger value, Nino.Serialization.Writer writer)
            {
                if(value == null)
                {
                    writer.Write(false);
                    return;
                }
                writer.Write(true);
                writer.CompressAndWrite(ref value.localId);
                writer.Write(value.actions);
            }

            public override ConfigEnterZoneEventTrigger Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                ConfigEnterZoneEventTrigger value = new ConfigEnterZoneEventTrigger();
                reader.DecompressAndReadNumber<System.Int32>(ref value.localId);
                value.actions = reader.ReadArray<TaoTie.ConfigGearAction>();
                return value;
            }
            #endregion
        }
    }
}