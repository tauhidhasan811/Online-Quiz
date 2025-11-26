# Online Quiz Backend

This repository contains the backend API for an online quiz application. It is built using C# and .NET, implementing a layered architecture. The backend handles user authentication, course management, quiz creation and administration, and student participation tracking. It utilizes Entity Framework for data access and AutoMapper for object mapping.

## Run Instructions

*   **Prerequisites**:
    *   .NET SDK installed
    *   SQL Server or compatible database
*   **Setup Database**:
    *   Run Entity Framework migrations to create the database schema.
*   **Build the Project**:
    *   Navigate to the project root directory.
    *   Run `dotnet build`
*   **Run the Application**:
    *   Navigate to the `PresentationLayer` directory.
    *   Run `dotnet run`

## Folder Structure

```
root
| ---> Online Quiz BackEnd
     | ---> BusinessLogicLayer
     |      | ---> Class1.cs
     |      | ---> CreateMap
     |      |      | ---> CreateMap.cs
     |      | ---> DTO
     |      |      | ---> CourseDTO.cs
     |      |      | ---> FacultyDTO.cs
     |      |      | ---> OptionDTO.cs
     |      |      | ---> QuestionDTO.cs
     |      |      | ---> QuizDTO.cs
     |      |      | ---> StudentDTO.cs
     |      |      | ---> StudentQuizDTO.cs
     |      |      | ---> TokenDTO.cs
     |      |      | ---> UserDTO.cs
     |      | ---> Services
     |      |      | ---> AuthServices.cs
     |      |      | ---> CourseService.cs
     |      |      | ---> FacultyService.cs
     |      |      | ---> OptionService.cs
     |      |      | ---> QuestionService.cs
     |      |      | ---> QuizService.cs
     |      |      | ---> StudentQuizService.cs
     |      |      | ---> StudentService.cs
     |      |      | ---> UserService.cs
     | ---> DataAccessLayer
     |      | ---> Context
     |      |      | ---> QuizContext.cs
     |      | ---> Enums
     |      |      | ---> QueTypeEnum.cs
     |      | ---> Interfaces
     |      |      | ---> IAuthRepo.cs
     |      |      | ---> ICommonRepo.cs
     |      |      | ---> IOptionRepo.cs
     |      |      | ---> IQuestionRepo.cs
     |      |      | ---> IQuizSpecificFeature.cs
     |      |      | ---> ISpecificRepo.cs
     |      |      | ---> IStudentQuizRepo.cs
     |      | ---> Repository
     |      |      | ---> AuthRepo.cs
     |      |      | ---> CourseRepo.cs
     |      |      | ---> FacultyRepo.cs
     |      |      | ---> OptionRepo.cs
     |      |      | ---> QuestionRepo.cs
     |      |      | ---> QuizRepo.cs
     |      |      | ---> StudentQuizRepo.cs
     |      |      | ---> StudentRepo.cs
     |      |      | ---> UserRepo.cs
     |      | ---> Tables
     |      |      | ---> Course.cs
     |      |      | ---> Faculty.cs
     |      |      | ---> Option.cs
     |      |      | ---> Question.cs
     |      |      | ---> Quiz.cs
     |      |      | ---> Student.cs
     |      |      | ---> StudentQuiz.cs
     |      |      | ---> Token.cs
     |      |      | ---> User.cs
     |      | ---> DataAccessFactory.cs
     | ---> PresentationLayer
     |      | ---> Authentic
     |      |      | ---> IsFaculty.cs
     |      |      | ---> LoggedIn.cs
     |      | ---> Controllers
     |      |      | ---> AuthController.cs
     |      |      | ---> CourseController.cs
     |      |      | ---> FacultyController.cs
     |      |      | ---> OptionController.cs
     |      |      | ---> QuestionController.cs
     |      |      | ---> QuizController.cs
     |      |      | ---> StudentController.cs
     |      |      | ---> StudentQuizController.cs
     |      | ---> Models
     |      |      | ---> studentquiz.cs
     |      |      | ---> studentquizUpdate.cs
     |      |      | ---> UserLog.cs
```

## File Descriptions

### BusinessLogicLayer

*   `Class1.cs`: An empty placeholder class for future business logic implementations in the `BusinessLogicLayer` namespace.
*   `CreateMap.cs`: Generic static classes for simplifying AutoMapper configuration, enabling bidirectional mapping between classes and DTOs.
*   `CourseDTO.cs`: Data Transfer Object representing course information with `Id`, `Name`, and `CourseCode`.
*   `FacultyDTO.cs`: Data Transfer Object for faculty information, including `Id`, `Name`, `UserName`, `Email`, and `Password`.
*   `OptionDTO.cs`: Data Transfer Object for quiz options, including text and correctness, with a required `Text` field.
*   `QuestionDTO.cs`: Data Transfer Object for quiz questions, including `Id`, `Title`, `QuestionType`, and `QuizId`, with required `Title`, `QuestionType`, and `QuizId`.
*   `QuizDTO.cs`: Data Transfer Object for quiz information, including title, marks, duration, dates, and navigation properties to `QuestionDTO` and `StudentQuizDTO`.
*   `StudentDTO.cs`: Data Transfer Object representing student information with `Id`, `Name`, `UserName`, `Email`, and `Password`.
*   `StudentQuizDTO.cs`: Data Transfer Object for student quiz interactions, tracking attempt times, marks, and links to student and quiz.
*   `TokenDTO.cs`: Data Transfer Object for authentication tokens, containing `Id`, `AccessToken`, timestamps, `UserId`, and `Type`.
*   `UserDTO.cs`: Data Transfer Object for user data, including `Id`, `UserName`, `Password`, `StudentId`, `FacultyId`, and `Type`.
*   `AuthServices.cs`: Handles user authentication and token generation, verifying credentials and returning a `TokenDTO`.
*   `CourseService.cs`: Manages business logic for courses, including create, delete, retrieve single, and retrieve all operations, interacting with `CourseDTO` and `Course` entities.
*   `FacultyService.cs`: Manages business logic for faculty data, including create, delete, retrieve single, and retrieve all operations, translating between `FacultyDTO` and `Faculty` entities.
*   `OptionService.cs`: Handles business logic for quiz options, including create, retrieve all, retrieve by question ID, and checking correct options.
*   `QuestionService.cs`: Manages business logic for quiz questions, including create, retrieve, update, and delete operations, mapping between `Question` entities and `QuestionDTO`.
*   `QuizService.cs`: Handles core quiz operations, including creating quizzes, retrieving all quizzes or a specific quiz, and fetching quizzes filtered by faculty ID.
*   `StudentQuizService.cs`: Manages student participation in quizzes, handling new attempts, retrieval, and specific attempt details, translating between DTOs and entities.
*   `StudentService.cs`: Handles business logic for student operations, including creating and updating student records by mapping `StudentDTO` to `Student` entities.
*   `UserService.cs`: Handles core user operations, providing methods to create new users and retrieve user data by ID, acting as an intermediary between presentation and data access layers.

### DataAccessLayer

*   `DataAccessFactory.cs`: A factory class for creating repository instances, abstracting concrete repository implementations.
*   `QuizContext.cs`: An Entity Framework `DbContext` for the online quiz application, establishing database access for various entities.
*   `QueTypeEnum.cs`: An enumeration defining different question types (`MultipleChoice`, `TrueFalse`, `ShortAnswer`, `FillInTheBlank`).
*   `IAuthRepo.cs`: Interface outlining the contract for authentication operations, including `Authentication` and `ValidId` methods.
*   `ICommonRepo.cs`: Generic interface for common data access operations (Create, Read, Update, Delete).
*   `IOptionRepo.cs`: Interface defining data access operations for quiz options, including retrieval by question ID and checking correctness.
*   `IQuestionRepo.cs`: Interface defining data access operations for quiz questions, including retrieving questions by quiz ID.
*   `IQuizSpecificFeature.cs`: Interface defining contracts for quiz-specific data access operations, including retrieval by faculty ID and name search.
*   `ISpecificRepo.cs`: Interface defining a contract for repositories that retrieve all entities of a specific type via a `GetALL()` method.
*   `IStudentQuizRepo.cs`: Interface defining data access operations for student quiz records, including retrieval by student ID.
*   `AuthRepo.cs`: Handles user authentication and token management, verifying credentials, generating tokens, and sanitizing user data.
*   `CourseRepo.cs`: Implements `ICommonRepo` for managing `Course` entities, providing CRUD operations via `QuizContext`.
*   `FacultyRepo.cs`: Manages data operations for `Faculty` entities, implementing `ICommonRepo` and creating a corresponding `User` record on creation.
*   `OptionRepo.cs`: Handles data operations for `Option` entities, performing CRUD operations and retrieving options by question ID.
*   `QuestionRepo.cs`: Handles data operations for `Question` entities, implementing common repository functions and specific quiz-related queries.
*   `QuizRepo.cs`: Acts as a data access layer for `Quiz` entities, handling CRUD operations and fetching quizzes filtered by faculty ID.
*   `StudentQuizRepo.cs`: Handles data operations for `StudentQuiz` entities, providing CRUD operations and retrieval by student ID.
*   `StudentRepo.cs`: Manages `Student` data persistence, implementing common repository operations and automatically creating a corresponding `User` entry.
*   `UserRepo.cs`: Acts as a data access layer for managing `User` entities, providing CRUD operations via `QuizContext`.
*   `Course.cs`: Represents a course entity with `Id`, `Name`, and `CourseCode`, with required `Name` and `CourseCode`.
*   `Faculty.cs`: Represents a faculty member with `Id`, `Name`, `UserName`, `Email`, and `Password`, with required fields.
*   `Option.cs`: Represents a single answer choice in a quiz, including text, `QuestionId`, and `IsCorrect` flag.
*   `Question.cs`: Represents a question entity with `Id`, `Title`, `Type`, `QuizId`, and associated `Option` objects.
*   `Quiz.cs`: Represents a quiz entity with properties like title, marks, duration, dates, and relationships to `Course`, `Faculty`, `Question`, and `StudentQuiz`.
*   `Student.cs`: Defines the data structure for student entities with `Id`, `Name`, `UserName`, `Email`, and `Password`, with required fields.
*   `StudentQuiz.cs`: Represents a student's participation in a quiz, including `StartTime`, `EndTime`, `Mark`, and links to `Student` and `Quiz`.
*   `Token.cs`: Represents authentication tokens with `AccessToken`, timestamps, `UserId`, and `Type`.
*   `User.cs`: Defines the structure for user data with `UserName`, `Password`, `Type`, and foreign key relationships to `Student` and `Faculty`.

### PresentationLayer

*   `IsFaculty.cs`: An attribute that restricts API endpoint access to users of "Faculty" type after token validation.
*   `LoggedIn.cs`: An HTTP Authorization Filter that secures endpoints by ensuring a valid access token is present.
*   `AuthController.cs`: Handles user authentication, exposing a `/login` endpoint, generating tokens, and setting them as cookies.
*   `CourseController.cs`: Handles API requests for course management, exposing endpoints for creating and retrieving courses, requiring authentication.
*   `FacultyController.cs`: Manages faculty-related operations, providing endpoints for creating, retrieving all, and updating faculty information, with access restrictions.
*   `OptionController.cs`: Manages quiz options, providing API endpoints for creating, retrieving all, and retrieving options by question ID, restricted to authenticated faculty.
*   `QuestionController.cs`: Manages quiz questions, exposing API endpoints for creating, retrieving all, and updating questions, with authentication and authorization enforced.
*   `QuizController.cs`: Manages quiz-related API endpoints, handling quiz creation, retrieval, and fetching specific quiz details, with authentication enforced.
*   `StudentController.cs`: Handles student-related API requests, exposing endpoints for creating, retrieving, updating, and deleting student records, with authentication enforced for most operations.
*   `StudentQuizController.cs`: Manages student quiz interactions, providing endpoints for students to create quiz attempts and submit answers.
*   `studentquiz.cs`: Represents the association between a student and a quiz, with `StudentId` and `QuizId` properties.
*   `studentquizUpdate.cs`: Model for updating student quiz answers, containing `squizid` and a list of `answers`.
*   `UserLog.cs`: A model representing user credentials for login or authentication, with `UserName` and `Password` properties.
