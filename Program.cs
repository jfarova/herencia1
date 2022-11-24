internal class Program
{
    private static void Main(string[] args)
    {
         estudiante estudiante1=new estudiante("juan","Maro",1314758965,"soltero","3C");
        profesor profesor1=new profesor("jose","madona",1468216955,"tristemente casado",506,1968,"Matematicas");
        trabajadorS trabajadorS1=new trabajadorS("fabian","flores",126387994,"divorcidado",710,1970,"biblioteca");

        estudiante1.cambiarEstadoCivil("Union libre");
        estudiante1.cambiarmatricula("4C");
        estudiante1.Imprimir();

       profesor1.cambiarEstadoCivil("Divorciado");
       profesor1.cambioDepartamento("Algebra");
       profesor1.cambioDespacho(50);
       profesor1.Imprimir();

       profesor1.cambiarEstadoCivil("Casado");
       profesor1.cambioDepartamento("Decanato");
       profesor1.cambioDespacho(630);
       profesor1.Imprimir();
    }
}