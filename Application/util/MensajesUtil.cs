namespace Application.util;

public class MensajesUtil
{
    public static void EnviarMensajeBienvenida()
    {
        List<string> mensaje = ObtenerMensajeBienvenida();
        
        EnviarMensaje(mensaje);
    }

    private static void EnviarMensaje(List<string> mensaje)
    {
        mensaje.ForEach(line => Console.WriteLine(line));
    }
    
    private static List<string> ObtenerMensajeBienvenida()
    {
        return new List<string>() {
            "",
            "			***************************************************",
            "			*                                                 *",
            "			*        Panaderias y Confiterias Carlitos        *",
            "			*                                                 *",
            "			***************************************************",
            "		 	Servicios de Catering, Bebidas, Personal de Atencion" + "\r\n" + "					y Manteleria/Blanca",
            ""
        };
    }
}