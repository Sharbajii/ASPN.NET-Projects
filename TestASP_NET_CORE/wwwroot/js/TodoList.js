let tasks = [
    {
        "title": "HTML, CSS, JS Project",
        "date": "23/07/2024",
        "isDone": true
    },
    {
        "title": "Finishing JS Toturial",
        "date": "24/07/2024",
        "isDone": false
    },
    {
        "title": "reading a book",
        "date": "25/07/2024",
        "isDone": false
    },
    {
        "title": "SQL Exercises",
        "date": "24/07/2024",
        "isDone": true
    }
]


getTaskFromStorge()

function getTaskFromStorge() {
    let retrievedTasks = JSON.parse(localStorage.getItem("tasks"))

    tasks = retrievedTasks ?? []
}


function fillTasksOnThePage() {

    document.getElementById("tasks").innerHTML = ""

    let index = 0
    for (task of tasks) {

        let content =
            `
         <div class="task ${task.isDone ? 'done' : ''} ">
    
            <!-- Task info -->
            <div style="width: 70%;">
                <h2>${task.title}</h2>
    
                <div>
                     <span class="material-symbols-outlined">
                        calendar_month
                    </span>
                    <span>
                    ${task.date}
                    </span>
                </div>
            </div>
          <!-- // Task Info // -->
    
          <!-- Task actions -->
             <div class="task-action">
                 <button onclick = "deleteTask(${index})" id="b1" class="circular">
                     <span class="material-symbols-outlined">
                         delete
                     </span>
                 </button>
                    
             ${task.isDone ? ` 
                 <button onclick = "toggleTaskCompletion(${index})" id="b2" class="circular" style="background-color: rgb(118, 0, 101)">
                    <span class="material-symbols-outlined">
                        cancel
                    </span>
                </button>` : `

                <button onclick = "toggleTaskCompletion(${index})" id="b2" class="circular">
                    <span class="material-symbols-outlined">
                        done
                    </span>
                </button>
             `}
               
     
                 <button onclick="editTask(${index})" id="b3" class="circular">
                     <span class="material-symbols-outlined">
                         edit
                     </span>
                 </button>
             </div>
                <!-- // Task actions // -->
          </div>
        `
        document.getElementById("tasks").innerHTML += content
        index++
    }
}


document.addEventListener("DOMContentLoaded", function (event) {
    fillTasksOnThePage();

});

//document.getElementById("add-btn").addEventListener("click", function () {
function clickAdd() {
    let taskName = prompt("Please Enter a Todo Task");

    if (taskName === null || taskName.trim() === "") {
        alert("Task name cannot be empty. Please enter a valid task name.");
        return; // Exit the function if the task name is empty
    }

    let now = new Date();
    let date = now.getDate() + "/" + (now.getMonth() + 1) + "/" + now.getFullYear() + " | " + now.getHours() + ":" + now.getMinutes();

    let taskObj = {
        "title": taskName,
        "date": date,
        "isDone": false
    };

    tasks.push(taskObj);

    storeTasks();
    fillTasksOnThePage();
}

function deleteTask(index) {
    let task = tasks[index]
    let confirmMsg = confirm("are you sure you want to delete this Task : " + task.title + " ?")

    if (confirmMsg) {
        tasks.splice(index, 1)
        storeTasks()
        fillTasksOnThePage()
    }

}

function editTask(index) {
    let task = tasks[index];
    if (task) {
        let newTaskTitle = prompt("Please enter the new task name", task.title);
        if (newTaskTitle !== null && newTaskTitle.trim() !== "") {
            task.title = newTaskTitle;
        }
        storeTasks()
        fillTasksOnThePage();
    } else {
        alert("Task not found");
    }
}

function toggleTaskCompletion(index) {
    let task = tasks[index]
    task.isDone = !task.isDone

    storeTasks()
    fillTasksOnThePage()
}

// Storge =========== Functions
function storeTasks() {
    let taskString = JSON.stringify(tasks)
    localStorage.setItem("tasks", taskString)
}