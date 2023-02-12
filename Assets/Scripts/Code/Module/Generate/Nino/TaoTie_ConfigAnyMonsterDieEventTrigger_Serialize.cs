/* this is generated by nino */
namespace TaoTie
{
    public partial class ConfigAnyMonsterDieEventTrigger
    {
        public static ConfigAnyMonsterDieEventTrigger.SerializationHelper NinoSerializationHelper = new ConfigAnyMonsterDieEventTrigger.SerializationHelper();
        public class SerializationHelper: Nino.Serialization.NinoWrapperBase<ConfigAnyMonsterDieEventTrigger>
        {
            #region NINO_CODEGEN
            public override void Serialize(ConfigAnyMonsterDieEventTrigger value, Nino.Serialization.Writer writer)
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

            public override ConfigAnyMonsterDieEventTrigger Deserialize(Nino.Serialization.Reader reader)
            {
                if(!reader.ReadBool())
                    return null;
                ConfigAnyMonsterDieEventTrigger value = new ConfigAnyMonsterDieEventTrigger();
                reader.DecompressAndReadNumber<System.Int32>(ref value.localId);
                value.actions = reader.ReadArray<TaoTie.ConfigGearAction>();
                return value;
            }
            #endregion
        }
    }
}