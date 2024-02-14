public class ToDoItemTests
{
    [Fact]
public void TestToDoItemCreation()
{
   
    var expectedId = 1;
    var expectedTaskDescription = "Test task";
    var expectedIsComplete = false;

   
    var toDoItem = new ToDoItem
    {
        Id = expectedId,
        TaskDescription = expectedTaskDescription,
        IsComplete = expectedIsComplete
    };

    
    Assert.Equal(expectedId, toDoItem.Id);
    Assert.Equal(expectedTaskDescription, toDoItem.TaskDescription);
    Assert.Equal(expectedIsComplete, toDoItem.IsComplete);
}

}
