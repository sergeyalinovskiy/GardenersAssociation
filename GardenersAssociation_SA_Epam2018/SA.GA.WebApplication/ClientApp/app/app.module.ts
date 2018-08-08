import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { UserListComponent } from './user.components/user-list.component';
import { UserFormComponent } from './user.components/user-form.component';
import { UserCreateComponent } from './user.components/user-create.component';
import { UserEditComponent } from './user.components/user-edit.component';

import { PlotListComponent } from './plot.components/plot-list.component';
import { PlotFormComponent } from './plot.components/plot-form.component';
import { PlotCreateComponent } from './plot.components/plot-create.component';
import { PlotEditComponent } from './plot.components/plot-edit.component';


import { NotFoundComponent } from './not-found.component';

import { DataService } from './data.service';

// определение маршрутов
const appRoutes: Routes = [
    { path: '', component: UserListComponent },
    { path: 'create', component: UserCreateComponent },
    { path: 'edit/:id', component: UserEditComponent },
    { path: '**', component: NotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, UserListComponent, UserCreateComponent, UserEditComponent,
        UserFormComponent, NotFoundComponent, PlotListComponent, PlotFormComponent, PlotCreateComponent,
        PlotEditComponent ],
    providers: [DataService], // регистрация сервисов
    bootstrap: [AppComponent]
})
export class AppModule { }