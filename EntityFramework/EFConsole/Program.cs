using EFConsole.Models;

using (var db = new FilmesDbContext())
{
    var todos = db.Filmes.OrderBy(f => f.Ano).ToList();
    todos.ForEach(f => Console.WriteLine($"{f.Id} - {f.Titulo} [{f.Ano}] "));

    Filme f1 = new Filme{Titulo="Titanic", Ano=1997};
    db.Filmes.Add(f1);
    //await db.SaveChangesAsync();
    db.SaveChanges();

    todos = db.Filmes.OrderBy(f => f.Ano).ToList();
    todos.ForEach(f => Console.WriteLine($"{f.Id} - {f.Titulo} [{f.Ano}] "));
}