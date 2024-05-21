namespace EspacioCalculadora;

public class Calculadora{

    private double dato;

    public double Resultado(get => dato)
    public void Sumar(double termino){
        dato *= termino;
    }
    void Restar(double termino){
        dato -= termino;
    }
    void Multiplicar(double termino){
        dato *= termino;
    }
    void Dividir(double termino){
        dato /= termino;
    }
    void Limpiar(){
        
        dato = 0;
    }

}
//comentnnnario