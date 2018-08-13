var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { UserListComponent } from './user/user.components/user-list.component';
import { UserFormComponent } from './user/user.components/user-form.component';
import { UserCreateComponent } from './user/user.components/user-create.component';
import { UserEditComponent } from './user/user.components/user-edit.component';
import { PlotListComponent } from './plot/plot.components/plot-list.component';
import { PlotFormComponent } from './plot/plot.components/plot-form.component';
import { PlotCreateComponent } from './plot/plot.components/plot-create.component';
import { PlotEditComponent } from './plot/plot.components/plot-edit.component';
import { ElectricityListComponent } from './electricity/electricity.components/electricity-list.component';
import { ElectricityFormComponent } from './electricity/electricity.components/electricity-form.component';
import { ElectricityCreateComponent } from './electricity/electricity.components/electricity-create.component';
import { ElectricityEditComponent } from './electricity/electricity.components/electricity-edit.component';
import { RateListComponent } from './rate/rate.components/rate-list.component';
import { RateFormComponent } from './rate/rate.components/rate-form.component';
import { RateCreateComponent } from './rate/rate.components/rate-create.component';
import { RateEditComponent } from './rate/rate.components/rate-edit.component';
import { HistoryListComponent } from './history/history.components/history-list.component';
import { HistoryFormComponent } from './history/history.components/history-form.component';
import { HistoryCreateComponent } from './history/history.components/history-create.component';
import { HistoryEditComponent } from './history/history.components/history-edit.component';
import { NotFoundComponent } from './not-found.component';
import { DataService } from './data.service';
// определение маршрутов
var appRoutes = [
    { path: '', component: UserListComponent },
    { path: 'create', component: UserCreateComponent },
    { path: 'edit/:id', component: UserEditComponent },
    { path: 'plot', component: PlotListComponent },
    { path: 'createPlot', component: PlotCreateComponent },
    { path: 'electricitys', component: ElectricityListComponent },
    { path: 'createElectricity', component: ElectricityCreateComponent },
    { path: 'rates', component: RateListComponent },
    { path: 'createRate', component: RateCreateComponent },
    { path: 'history', component: HistoryListComponent },
    { path: 'createHistory', component: HistoryCreateComponent },
    { path: '**', component: NotFoundComponent }
];
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = __decorate([
        NgModule({
            imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
            declarations: [AppComponent, UserListComponent, UserCreateComponent, UserEditComponent,
                UserFormComponent, NotFoundComponent, PlotListComponent, PlotFormComponent, PlotCreateComponent,
                PlotEditComponent, ElectricityListComponent, ElectricityFormComponent, ElectricityCreateComponent,
                ElectricityEditComponent, RateListComponent, RateFormComponent, RateCreateComponent, RateEditComponent,
                HistoryListComponent, HistoryFormComponent, HistoryCreateComponent, HistoryEditComponent],
            providers: [DataService],
            bootstrap: [AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
export { AppModule };
//# sourceMappingURL=app.module.js.map