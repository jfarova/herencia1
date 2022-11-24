
    class estudiante:persona{
    private string curso{get; set;}

    public estudiante(string nombre, string apellido, int numeroIdentificacion, string estadoCivil, string curso):base(nombre, apellido, numeroIdentificacion, estadoCivil){
        this.curso=curso;
    }

    public void cambiarmatricula(string curso2){
        curso=curso2;
        Console.WriteLine("su semestre matriculado es: " + curso);
}
    }