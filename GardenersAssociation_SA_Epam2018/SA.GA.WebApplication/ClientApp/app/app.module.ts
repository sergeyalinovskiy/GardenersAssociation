import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { Routes, RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { UserListComponent } from './user/user.components/user-list.component';
import { UserFormComponent } from './user/user.components/user-form.component';
import { UserCreateComponent } from './user/user.components/user-create.component';
import { UserEditComponent } from './user/user.components/user-edit.component';

import { PlotListComponent } from './plot/plot.components/plot-list.component';
import { PlotFormComponent } from './plot/plot.components/plot-form.component';
import { PlotCreateComponent } from './plot/plot.components/plot-create.component';
import { PlotEditComponent } from './plot/plot.components/plot-edit.component';
import { PlotUserComponent } from './plot/plot.components/plot-user.component';

import { ElectricityListComponent } from './electricity/electricity.components/electricity-list.component';
import { ElectricityFormComponent } from './electricity/electricity.components/electricity-form.component';
import { ElectricityCreateComponent } from './electricity/electricity.components/electricity-create.component';
import { ElectricityEditComponent } from './electricity/electricity.components/electricity-edit.component';
import { ElectricityPlotComponent } from './electricity/electricity.components/electricity-plot.component';

import { RateListComponent } from './rate/rate.components/rate-list.component';
import { RateFormComponent } from './rate/rate.components/rate-form.component';
import { RateCreateComponent } from './rate/rate.components/rate-create.component';
import { RateEditComponent } from './rate/rate.components/rate-edit.component';
import { RateComponent } from './rate/rate.components/rate-rate.component';


import { HistoryListComponent } from './history/history.components/history-list.component';
import { HistoryFormComponent } from './history/history.components/history-form.component';
import { HistoryCreateComponent } from './history/history.components/history-create.component';
import { HistoryEditComponent } from './history/history.components/history-edit.component';



import { NotFoundComponent } from './not-found.component';


import { DataServiceElectricity } from './data-service/data.service.electricity';
import { DataServiceHistory } from './data-service/data.service.history';
import { DataServicePlot } from './data-service/data.service.plot';
import { DataServiceRate } from './data-service/data.service.rate';
import { DataServiceUser } from './data-service/data.service.user';

// определение маршрутов
const appRoutes: Routes = [
    { path: '', component: UserListComponent },
    { path: 'create', component: UserCreateComponent },
    { path: 'edit/:id', component: UserEditComponent },
    { path: 'getPlots/:id', component: PlotUserComponent },
    { path: 'plot', component: PlotListComponent },
    { path: 'createPlot', component: PlotCreateComponent },
    { path: 'editPlot/:id', component: PlotEditComponent },
    { path: 'electricitys', component: ElectricityListComponent },
    { path: 'createElectricity', component: ElectricityCreateComponent },
    { path: 'editElectricity/:id', component: ElectricityEditComponent },
    { path: 'getPlotElectricity/:id', component: ElectricityPlotComponent },
    { path: 'rates', component: RateListComponent },
    { path: 'api/electricitys/GetRateInfo/:id', component: RateComponent },
    { path: 'editRate/:id', component: RateEditComponent },
    { path: 'createRate', component: RateCreateComponent },
    { path: 'history', component: HistoryListComponent },
    { path: 'createHistory', component: HistoryCreateComponent },
    { path: 'editHistory/:id', component: HistoryEditComponent },
    { path: '**', component: NotFoundComponent }
];

@NgModule({
    imports: [BrowserModule, FormsModule, HttpClientModule, RouterModule.forRoot(appRoutes)],
    declarations: [AppComponent, UserListComponent, UserCreateComponent, UserEditComponent,
        UserFormComponent, NotFoundComponent, PlotListComponent, PlotFormComponent, PlotCreateComponent,
        PlotEditComponent, ElectricityListComponent, ElectricityFormComponent, ElectricityCreateComponent,
        ElectricityEditComponent, RateListComponent, RateFormComponent, RateCreateComponent, RateEditComponent,
        HistoryListComponent, HistoryFormComponent, HistoryCreateComponent, HistoryEditComponent, RateComponent,
        PlotUserComponent, ElectricityPlotComponent],
    providers: [DataServiceElectricity,DataServiceHistory,DataServicePlot, DataServiceRate, DataServiceUser], // регистрация сервисов
    bootstrap: [AppComponent]
})
export class AppModule { }