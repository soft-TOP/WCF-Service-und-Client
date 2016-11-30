using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "IService" sowohl im Code als auch in der Konfigurationsdatei ändern.
[ServiceContract]
public interface IServiceTOP
{

    [OperationContract]
    String LiesZahl(Int32 value);

    [OperationContract]
    Pausenzeiten LiesPausenzeiten(Boolean Pause);

    // TODO: Hier Dienstvorgänge hinzufügen
}

// Verwenden Sie einen Datenvertrag, wie im folgenden Beispiel dargestellt, um Dienstvorgängen zusammengesetzte Typen hinzuzufügen.
[DataContract]
public class Pausenzeiten
{
    Boolean aktuellPause = false;
    List<String> pause = new List<String> { "09:30 - 09:45", "11:15 - 11:30", "13:00 - 13:30", "15:00 - 15:15", "16:45 - 08:00" };

    [DataMember]
    public Boolean AktuellPause
    {
        get { return aktuellPause; }
        set { aktuellPause = value; }
    }

    [DataMember]
    public List<String> Pause
    {
        get { return pause; }
        set { pause = value; }
    }
}
