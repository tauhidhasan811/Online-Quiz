# OnlineQuizFrontend

This project is an Angular-based frontend for an online quiz application. It leverages the Angular CLI for development, scaffolding, building, and testing. Key commands include `ng serve` for local development, `ng build` for production builds, and `ng test` for running unit tests.

## Run Instructions

1. **Install Dependencies:**
   - `npm install`

2. **Serve the Application:**
   - `ng serve`

3. **Run Unit Tests:**
   - `ng test`

4. **Build for Production:**
   - `ng build`

## Folder Structure

```
root
  |---> .gitignore
  |---> README.md
  |---> src
  |     |---> index.html
  |     |---> main.ts
  |     |---> styles.css
  |     |---> app
  |     |     |---> app.component.css
  |     |     |---> app.component.html
  |     |     |---> app.component.spec.ts
  |     |     |---> app.component.ts
  |     |     |---> app.config.ts
  |     |     |---> app.routes.ts
  |     |     |---> pages
  |     |     |     |---> auth
  |     |     |     |     |---> log-in
  |     |     |     |     |     |---> log-in.component.css
  |     |     |     |     |     |---> log-in.component.html
  |     |     |     |     |     |---> log-in.component.spec.ts
  |     |     |     |     |     |---> log-in.component.ts
  |     |     |---> course
  |     |     |     |---> course-create
  |     |     |     |     |---> course-create.component.css
  |     |     |     |     |---> course-create.component.html
  |     |     |     |     |---> course-create.component.spec.ts
  |     |     |     |     |---> course-create.component.ts
  |     |     |     |---> course-show
  |     |     |     |     |---> course-show.component.css
  |     |     |     |     |---> course-show.component.html
  |     |     |     |     |---> course-show.component.spec.ts
  |     |     |     |     |---> course-show.component.ts
  |     |     |     |---> course-update
  |     |     |     |     |---> course-update.component.css
  |     |     |     |     |---> course-update.component.html
  |     |     |     |     |---> course-update.component.spec.ts
  |     |     |     |     |---> course-update.component.ts
  |     |     |---> faculty
  |     |     |     |---> faculty-create
  |     |     |     |     |---> faculty-create.component.css
  |     |     |     |     |---> faculty-create.component.html
  |     |     |     |     |---> faculty-create.component.spec.ts
  |     |     |     |     |---> faculty-create.component.ts
  |     |     |     |---> faculty-show
  |     |     |     |     |---> faculty-show.component.css
  |     |     |     |     |---> faculty-show.component.html
  |     |     |     |     |---> faculty-show.component.spec.ts
  |     |     |     |     |---> faculty-show.component.ts
  |     |     |     |---> faculty-update
  |     |     |     |     |---> faculty-update.component.css
  |     |     |     |     |---> faculty-update.component.html
  |     |     |     |     |---> faculty-update.component.spec.ts
  |     |     |     |     |---> faculty-update.component.ts
  |     |     |---> home
  |     |     |     |---> home.component.css
  |     |     |     |---> home.component.html
  |     |     |     |---> home.component.spec.ts
  |     |     |     |---> home.component.ts
  |     |     |---> question
  |     |     |     |---> question-create
  |     |     |     |     |---> question-create.component.css
  |     |     |     |     |---> question-create.component.html
  |     |     |     |     |---> question-create.component.spec.ts
  |     |     |     |     |---> question-create.component.ts
  |     |     |     |---> question-show
  |     |     |     |     |---> question-show.component.css
  |     |     |     |     |---> question-show.component.html
  |     |     |     |     |---> question-show.component.spec.ts
  |     |     |     |     |---> question-show.component.ts
  |     |     |     |---> question-update
  |     |     |     |     |---> question-update.component.css
  |     |     |     |     |---> question-update.component.html
  |     |     |     |     |---> question-update.component.spec.ts
  |     |     |     |     |---> question-update.component.ts
  |     |     |---> quiz
  |     |     |     |---> quiz-attended
  |     |     |     |     |---> quiz-attended.component.css
  |     |     |     |     |---> quiz-attended.component.html
  |     |     |     |     |---> quiz-attended.component.spec.ts
  |     |     |     |     |---> quiz-attended.component.ts
  |     |     |     |---> quiz-create
  |     |     |     |     |---> quiz-create.component.css
  |     |     |     |     |---> quiz-create.component.html
  |     |     |     |     |---> quiz-create.component.spec.ts
  |     |     |     |     |---> quiz-create.component.ts
  |     |     |     |---> quiz-details
  |     |     |     |     |---> quiz-details.component.css
  |     |     |     |     |---> quiz-details.component.html
  |     |     |     |     |---> quiz-details.component.spec.ts
  |     |     |     |     |---> quiz-details.component.ts
  |     |     |     |---> quiz-show
  |     |     |     |     |---> quiz-show.component.css
  |     |     |     |     |---> quiz-show.component.html
  |     |     |     |     |---> quiz-show.component.spec.ts
  |     |     |     |     |---> quiz-show.component.ts
  |     |     |     |---> quiz-show-student
  |     |     |     |     |---> quiz-show-student.component.css
  |     |     |     |     |---> quiz-show-student.component.html
  |     |     |     |     |---> quiz-show-student.component.spec.ts
  |     |     |     |     |---> quiz-show-student.component.ts
  |     |     |     |---> quiz-update
  |     |     |     |     |---> quiz-update.component.css
  |     |     |     |     |---> quiz-update.component.html
  |     |     |     |     |---> quiz-update.component.spec.ts
  |     |     |     |     |---> quiz-update.component.ts
  |     |     |---> student
  |     |     |     |---> student-create
  |     |     |     |     |---> student-create.component.html
  |     |     |     |     |---> student-create.component.spec.ts
  |     |     |     |     |---> student-create.component.ts
  |     |     |     |---> student-show
  |     |     |     |     |---> student-show.component.css
  |     |     |     |     |---> student-show.component.html
  |     |     |     |     |---> student-show.component.spec.ts
  |     |     |     |     |---> student-show.component.ts
  |     |     |     |---> student-update
  |     |     |     |     |---> student-update.component.css
  |     |     |     |     |---> student-update.component.html
  |     |     |     |     |---> student-update.component.spec.ts
  |     |     |     |     |---> student-update.component.ts
```

## File Descriptions

### `.gitignore`
This `.gitignore` file specifies files and directories that Git should ignore. It prevents compiled code, Node.js dependencies, IDE configurations, editor caches, and system files from being tracked in the repository. This ensures a clean and focused version history for the OnlineQuizFrontend project.

### `README.md`
This project is an Angular-based frontend for an online quiz application. It leverages the Angular CLI for development, scaffolding, building, and testing. Key commands include `ng serve` for local development, `ng build` for production builds, and `ng test` for running unit tests.

### `src/index.html`
This HTML file serves as the entry point for the Online Quiz frontend application. It sets up the basic structure of the web page, including character encoding, title, and viewport settings for responsiveness. The `<app-root>` tag is a custom element where the Angular application will be bootstrapped and rendered.

### `src/main.ts`
This `main.ts` file is the entry point for the Angular application. It uses `bootstrapApplication` to initialize and launch the `AppComponent`. This process sets up the necessary configurations defined in `appConfig` and renders the main application component in the browser. Any errors during bootstrapping are logged to the console.

### `src/styles.css`
This CSS file serves as the global stylesheet for the Online Quiz frontend application. It's the central place to define styles that apply across the entire application, ensuring visual consistency. You can also import other CSS files here to organize your styling further.

### `src/app/app.component.css`
This CSS file styles the main application component of an online quiz frontend. It likely defines global styles for the layout, typography, and key interactive elements like buttons and input fields. The aim is to create a clean, user-friendly, and visually consistent interface for the quiz experience.

### `src/app/app.component.html`
This HTML file defines the navigation bar for an online quiz application. It uses Bootstrap for styling and Angular's routing to manage navigation. The bar displays "Log In" or "Log Out" options based on the user's authentication status (`userId`). It also includes a "Student" dropdown, conditionally shown if the user type is not "Faculty".

### `src/app/app.component.spec.ts`
This file contains unit tests for the main `AppComponent` of the Online Quiz Frontend Angular application. It verifies that the application component can be created, has the expected title, and renders a greeting containing that title. These tests ensure the basic functionality and initial state of the application's root component.

### `src/app/app.component.ts`
This Angular component serves as the root of the online quiz frontend application. It handles basic routing and provides access to user session information like `usertype` and `userId`. The `logOut` method facilitates user logout by making an HTTP POST request to the backend and then redirects the user to the login page upon successful logout.

### `src/app/app.config.ts`
This file configures the Angular application. It sets up the router to handle navigation based on the defined `routes`. It also enables zone change detection, which is crucial for Angular's change detection mechanism to efficiently update the UI. The commented-out section shows an example of adding an HTTP client with an authentication interceptor for handling API requests.

### `src/app/app.routes.ts`
This file defines the routing configuration for the Angular application. It maps specific URL paths to different components, enabling navigation between various views. Key routes include the home page, student management (create, update, show), quiz management, course management, faculty management, and authentication (login). It also includes routes for managing questions within quizzes.

### `src/app/pages/auth/log-in/log-in.component.css`
This CSS file styles the login page for the online quiz application. It focuses on creating a visually appealing and user-friendly interface for the login form. Key elements styled include the container, input fields, and buttons, ensuring a consistent and modern look.

### `src/app/pages/auth/log-in/log-in.component.html`
This HTML file defines the user interface for a login page in an online quiz application. It includes a form for users to enter their username and password. Upon submission, the `OnSubmit()` method is called, likely to authenticate the user. The page features a prominent "Online Quiz" heading and uses Bootstrap for styling, creating a responsive and visually appealing layout.

### `src/app/pages/auth/log-in/log-in.component.spec.ts`
This file contains unit tests for the `LogInComponent` in an Angular application. It verifies that the component can be successfully created and instantiated. The tests are set up using Angular's testing utilities, including `ComponentFixture` and `TestBed`, to isolate and test the component's behavior.

### `src/app/pages/auth/log-in/log-in.component.ts`
This Angular component handles user login functionality. It uses `ReactiveFormsModule` for form handling and `HttpClient` to send credentials to a backend API for validation. Upon successful validation, it stores the user ID and type in `sessionStorage` and navigates the user to the quiz page. If validation fails or an error occurs, it clears `sessionStorage`.

### `src/app/pages/course/course-create/course-create.component.css`
This CSS file styles the course creation page. It focuses on layout and visual presentation, ensuring input fields and buttons are well-aligned and aesthetically pleasing. The styles likely aim for a clean and user-friendly interface for adding new courses.

### `src/app/pages/course/course-create/course-create.component.html`
This HTML template defines a form for creating a new course. It uses Angular's `formGroup` and `formControlName` directives to bind input fields for "Name" and "Course Code" to a form model. Upon submission, the `onSubmit()` method is triggered, likely to send the course data for creation.

### `src/app/pages/course/course-create/course-create.component.spec.ts`
This code defines unit tests for the `CourseCreateComponent` in an Angular application. It uses the `TestBed` to set up the testing environment and creates an instance of the component. The primary test verifies that the `CourseCreateComponent` can be successfully instantiated, ensuring its basic functionality and setup.

### `src/app/pages/course/course-create/course-create.component.ts`
This Angular component handles the creation of new courses. It uses a reactive form with `FormGroup` and `FormControl` to capture course name and code. Upon submission, it sends this data via an HTTP POST request to the `/api/course/create` endpoint. The `HttpClient` is injected for making API calls.

### `src/app/pages/course/course-show/course-show.component.css`
This CSS file styles the "Course Show" page of the online quiz application. It focuses on presenting course information clearly, including a prominent title, a detailed description area, and a visually distinct section for quiz-related elements. The styles aim for a clean and organized user experience.

### `src/app/pages/course/course-show/course-show.component.html`
This HTML template displays a list of courses in a table format. It iterates through a `courses` array, showing the `Id`, `Name`, and `CourseCode` for each course. The table uses Bootstrap classes for styling.

### `src/app/pages/course/course-show/course-show.component.spec.ts`
This file contains unit tests for the `CourseShowComponent` in an Angular application. It verifies that the component can be successfully created. The tests are set up using Angular's testing utilities to isolate and test the component's behavior.

### `src/app/pages/course/course-show/course-show.component.ts`
This Angular component, `CourseShowComponent`, is responsible for fetching and displaying a list of courses. Upon initialization, it makes an HTTP GET request to a backend API endpoint (`https://localhost:44398/api/course/getall`). The retrieved course data is then stored in the `courses` property and logged to the console for debugging.

### `src/app/pages/course/course-update/course-update.component.css`
This CSS file styles the course update page. It primarily focuses on creating a visually appealing and organized layout for the course update form. Key styles include centering the form container, controlling input field widths, and adding spacing for better readability.

### `src/app/pages/course/course-update/course-update.component.html`
This HTML template defines the user interface for updating course details. It displays a simple "course-update works!" message, indicating the component is active. Further implementation within this file will add form elements to edit and submit course information.

### `src/app/pages/course/course-update/course-update.component.spec.ts`
This file contains unit tests for the `CourseUpdateComponent` in an Angular application. It ensures that the component can be created successfully and verifies its basic functionality. The tests use Angular's testing utilities to set up the component's environment and inspect its state.

### `src/app/pages/course/course-update/course-update.component.ts`
This Angular component, `CourseUpdateComponent`, is designed for the user interface of updating course information. It likely handles displaying existing course details and providing input fields for modifications. The component's template and styles are defined in separate HTML and CSS files, respectively.

### `src/app/pages/faculty/faculty-create/faculty-create.component.css`
This CSS file styles the "Faculty Create" page for an online quiz application. It focuses on the visual layout and appearance of elements used for creating new faculty profiles. Key styling includes controlling the presentation of forms, input fields, and buttons to ensure a user-friendly and organized interface for administrators.

### `src/app/pages/faculty/faculty-create/faculty-create.component.html`
This HTML file defines a form for faculty registration. It utilizes Angular's `formGroup` and `formControlName` for reactive form handling. The form collects faculty details such as Name, UserName, Email, and Password. Upon submission, the `onSubmit()` method is triggered to process the entered data.

### `src/app/pages/faculty/faculty-create/faculty-create.component.spec.ts`
This code defines unit tests for the `FacultyCreateComponent` in an Angular application. It sets up the testing environment, creates an instance of the component, and verifies that the component is successfully created. The primary purpose is to ensure the basic functionality of the faculty creation component.

### `src/app/pages/faculty/faculty-create/faculty-create.component.ts`
This Angular component, `FacultyCreateComponent`, is responsible for the user interface and logic to create a new faculty member. It utilizes reactive forms for input validation and collects faculty details such as Name, Username, Email, and Password. Upon submission, it sends this data via an HTTP POST request to a backend API endpoint.

### `src/app/pages/faculty/faculty-show/faculty-show.component.css`
This CSS file styles the `faculty-show.component` for the online quiz application. It focuses on presenting faculty member details clearly and attractively. Key styling elements include layout adjustments, font styles, and visual separation of information for improved readability.

### `src/app/pages/faculty/faculty-show/faculty-show.component.html`
This HTML template displays a table of faculty members fetched from the backend. It iterates through a list of `faculties` to show their ID, Name, Username, and Email. The `{{status}}` variable likely displays the current status of the data retrieval or any relevant messages.

### `src/app/pages/faculty/faculty-show/faculty-show.component.spec.ts`
This file contains unit tests for the `FacultyShowComponent` in an Angular application. It verifies that the component can be successfully created and initialized. The tests are set up using Angular's testing utilities, ensuring the component's basic functionality is sound before deployment.

### `src/app/pages/faculty/faculty-show/faculty-show.component.ts`
This Angular component, `FacultyShowComponent`, is responsible for fetching and displaying a list of faculty members. It uses `HttpClient` to make a GET request to an API endpoint. Crucially, it handles potential unauthorized access (HTTP status 401) by redirecting the user to the login page.

### `src/app/pages/faculty/faculty-update/faculty-update.component.css`
This CSS file styles the faculty update page, ensuring a clean and organized layout for faculty members to edit their information. It focuses on presenting form elements clearly and responsively, making the update process user-friendly. Key elements like input fields, labels, and buttons are styled for optimal readability and interaction.

### `src/app/pages/faculty/faculty-update/faculty-update.component.html`
This HTML file defines the user interface for the faculty update page. It displays a simple "faculty-update works!" message, indicating that the component is render
