namespace Anonymous;


internal class Notebook
{
  internal List<object> AllNotes { get; set; }

  internal Notebook() => AllNotes = new List<object>();

  internal void AddNote(string name, State state)
  {
    var Note = new { NoteName = name, NoteState = state };
    AllNotes.Add(Note);
  }

  internal List<string> GetNotes(State state)
  {
    List<string> NotesWithState = new List<string>();

    foreach (var note in AllNotes)
    {
      var noteState = note.GetType().GetProperty("NoteState").GetValue(note);

      if(noteState.ToString() == state.ToString()){
        var noteName = note.GetType().GetProperty("NoteName").GetValue(note);
        NotesWithState.Add(noteName.ToString());
      }
    }
    return NotesWithState;
  }
}

