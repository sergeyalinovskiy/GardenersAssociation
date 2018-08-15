import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './models/user';
import { Plot } from './models/plot';
import { Electricity } from './models/electricity';
import { Rate } from './models/rate';
import { History } from './models/history';

@Injectable()
export class DataService {

    private urlUser = "/api/users";
    private urlPlot = "/api/plot";
    private urlRate = "/api/rates";
    private urlHistory = "/api/history";
    private urlElectricity = "/api/electricitys";
    

    constructor(private http: HttpClient) {
    }

    getUsers() {
        return this.http.get(this.urlUser);
    }

    getUser(id: number) {
        return this.http.get(this.urlUser + '/' + id);
    }

    createUser(user: User) {
        return this.http.post(this.urlUser, user);
    }

    updateUser(user: User) {
        return this.http.put(this.urlUser + '/' + user.id, user);
    }

    deleteUser(id: number) {
        return this.http.delete(this.urlUser + '/' + id);
    }



    getPlots() {
        return this.http.get(this.urlPlot);
    }

    getPlot(id: number) {
        return this.http.get(this.urlPlot + '/' + id);
    }

    createPlot(plot: Plot) {
        return this.http.post(this.urlPlot, plot);
    }

    updatePlot(plot: Plot) {
        return this.http.put(this.urlPlot + '/' + plot.id, plot);
    }

    deletePlot(id: number) {
        return this.http.delete(this.urlPlot + '/' + id);
    }


    getElectricitys() {
        return this.http.get(this.urlElectricity);
    }

    getElectricity(id: number) {
        return this.http.get(this.urlElectricity + '/' + id);
    }

    createElectricity(electricity: Electricity) {
        return this.http.post(this.urlElectricity, electricity);
    }

    updateElectricity(electricity: Electricity) {
        return this.http.put(this.urlElectricity + '/' + electricity.id, electricity);
    }

    deleteElectricity(id: number) {
        return this.http.delete(this.urlElectricity + '/' + id);
    }

    getRateInfo(id: number) {
        return this.http.get(this.urlElectricity + '/' + 'GetRateInfo' + '/' + id);
    }


    getUserPlots(id: number) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    }

    getPlotElectricity(id: number) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    }



    getRates() {
        return this.http.get(this.urlRate);
    }

    getRate(id: number) {
        return this.http.get(this.urlRate + '/' + id);
    }

    createRate(rate: Rate) {
        return this.http.post(this.urlRate, rate);
    }

    updateRate(rate: Rate) {
        return this.http.put(this.urlRate + '/' + rate.id, rate);
    }

    deleteRate(id: number) {
        return this.http.delete(this.urlRate + '/' + id);
    }


    getHistorys() {
        return this.http.get(this.urlHistory);
    }

    getHistory(id: number) {
        return this.http.get(this.urlHistory + '/' + id);
    }

    createHistory(history: History) {
        return this.http.post(this.urlHistory, history);
    }

    updateHistory(history: History) {
        return this.http.put(this.urlHistory + '/' + history.id, history);
    }

    deleteHistory(id: number) {
        return this.http.delete(this.urlHistory + '/' + id);
    }

}