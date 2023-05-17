using ObservablePattern;

Match match = new Match();
Viewer viewer = new Viewer(match);

match.Add(viewer);

match.SetScore(5);