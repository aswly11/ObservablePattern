using ObservablePattern;

Observable<int> observable = new();
Match match = new Match(observable);

Viewer viewer = new Viewer(match);

match.Subscribe(viewer);

match.SetScore(5);
