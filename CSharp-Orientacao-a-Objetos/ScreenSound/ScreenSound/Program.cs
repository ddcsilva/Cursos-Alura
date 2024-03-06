using ScreenSound;

Album albumDoQueen = new Album();
albumDoQueen.Nome = "A Night at the Opera";

Musica musicaQueen1 = new Musica();
musicaQueen1.Nome = "Love of My Life";
musicaQueen1.Duracao = 213;

Musica musicaQueen2 = new Musica();
musicaQueen2.Nome = "Bohemian Rhapsody";
musicaQueen2.Duracao = 354;

albumDoQueen.AdicionarMusica(musicaQueen1);
albumDoQueen.AdicionarMusica(musicaQueen2);

albumDoQueen.ExibirMusicas();