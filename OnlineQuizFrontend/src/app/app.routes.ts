import { Routes } from '@angular/router';
import { StudentCreateComponent } from './pages/student/student-create/student-create.component';
import { HomeComponent } from './pages/home/home.component';
import { StudentUpdateComponent } from './pages/student/student-update/student-update.component';
import { StudentShowComponent } from './pages/student/student-show/student-show.component';
import { QuizCreateComponent } from './pages/quiz/quiz-create/quiz-create.component';
import { QuizUpdateComponent } from './pages/quiz/quiz-update/quiz-update.component';
import { QuizShowComponent } from './pages/quiz/quiz-show/quiz-show.component';
import { CourseCreateComponent } from './pages/course/course-create/course-create.component';
import { CourseUpdateComponent } from './pages/course/course-update/course-update.component';
import { CourseShowComponent } from './pages/course/course-show/course-show.component';
import { FacultyCreateComponent } from './pages/faculty/faculty-create/faculty-create.component';
import { FacultyShowComponent } from './pages/faculty/faculty-show/faculty-show.component';
import { FacultyUpdateComponent } from './pages/faculty/faculty-update/faculty-update.component';
import { LogInComponent } from './pages/auth/log-in/log-in.component';
import { QuestionCreateComponent } from './pages/question/question-create/question-create.component';
import { QuestionUpdateComponent } from './pages/question/question-update/question-update.component';
import { QuestionShowComponent } from './pages/question/question-show/question-show.component';
import { QuizDetailsComponent } from './pages/quiz/quiz-details/quiz-details.component';
import { QuizAttendedComponent } from './pages/quiz/quiz-attended/quiz-attended.component';
import { QuizShowStudentComponent } from './pages/quiz/quiz-show-student/quiz-show-student.component';

export const routes: Routes = [
        {path:'', component:LogInComponent},
        //{path:'home', component:HomeComponent},
        {path:'log-in', component:LogInComponent},
        {path:'student-create', component:StudentCreateComponent},
        {path:'student-update', component:StudentUpdateComponent},
        {path:'student-show', component:StudentShowComponent},
        {path:'quiz-create', component:QuizCreateComponent}, 
        {path:'quiz-update', component:QuizUpdateComponent},
        {path:'quiz-show', component:QuizShowComponent},
        {path:'quiz-details/:id', component:QuizDetailsComponent},
        {path:'quiz-attempt/:studentid', component:QuizAttendedComponent},
        {path:'quiz-show-student', component:QuizShowStudentComponent},
        {path:'course-create', component:CourseCreateComponent},
        {path:'course-update', component:CourseUpdateComponent},
        {path:'course-show', component:CourseShowComponent},
        {path:'faculty-create', component:FacultyCreateComponent},
        {path:'faculty-show', component:FacultyShowComponent},
        {path:'faculty-update', component:FacultyUpdateComponent}, 
        {path: 'question-create/:id', component:QuestionCreateComponent},
        {path: 'question-update', component:QuestionUpdateComponent},
        {path: 'question-show/:id', component:QuestionShowComponent}
];
