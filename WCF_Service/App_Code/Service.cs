using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "Service" sowohl im Code als auch in der SVC- und der Konfigurationsdatei ändern.
public class Service : IServiceTOP
{
    public String LiesZahl(Int32 value)
    {
        return String.Format("Eingabe war: {0}", value);
    }

    public Pausenzeiten LiesPausenzeiten(Boolean Pause)
    {
        Pausenzeiten p = new Pausenzeiten();
        if (Pause)
        {
            p.Pause.Add("Jetzt ist Pause");
        }
        return p;
    }
}
