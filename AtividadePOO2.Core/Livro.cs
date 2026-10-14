namespace AtividadePOO2.Core;

public class Livro
{
    public string Titulo { get; private set; }
    public string Paginas { get; private set; }
    public string Sinopse { get; private set; }
    public string Categoria { get; private set; }
    public string Autor { get; private set; }


    public Livro(string titulo, string paginas, string sinopse, string categoria, string autor)
    {
        ValidarTitulo(titulo);
        ValidarPaginas(paginas);
        ValidarSinopse(sinopse);
        ValidarCategoria(categoria);
        ValidarAutor(autor);
    }

    private int MINIMO_QUANTIDADE_PAGINA = 13;

    private void ValidarTitulo(string titulo)
    {
        if (string.IsNullOrWhiteSpace(titulo))
            throw new Exception("Titulo não encontrado!");
        Titulo = titulo;
    }
    
    private void ValidarPaginas(string paginas)
    {
        if (string.IsNullOrWhiteSpace(paginas))
            throw new Exception("Número de página invalida!");
        Paginas = paginas;
    }
    
    private void ValidarSinopse(string sinopse)
    {
        if (string.IsNullOrWhiteSpace(sinopse))
            throw new Exception("A sinopse não pode ficar vazia!");
        
        
        Sinopse = sinopse;
    }
    
    private void ValidarCategoria(string categoria)
    {
        if (string.IsNullOrWhiteSpace(categoria))
            throw new Exception("A categoria deve ser preenchida!");
        Categoria = categoria;
    }
    
    private void ValidarAutor(string autor)
    {
        if (string.IsNullOrWhiteSpace(autor))
            throw new Exception("Tem que ter uma assinatura do autor!");
        Autor = autor;
    }
}