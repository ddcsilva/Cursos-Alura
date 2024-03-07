using ScreenSound;

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A Night at the Opera");

Musica musicaQueen1 = new Musica(queen, "Love of My Life")
{
    Duracao = 213,
    Disponivel = true
};

Musica musicaQueen2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false
};

albumDoQueen.AdicionarMusica(musicaQueen1);
albumDoQueen.AdicionarMusica(musicaQueen2);
queen.AdicionarAlbum(albumDoQueen);

musicaQueen1.ExibirFichaTecnica();
musicaQueen2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicas();
queen.ExibirDiscografia();