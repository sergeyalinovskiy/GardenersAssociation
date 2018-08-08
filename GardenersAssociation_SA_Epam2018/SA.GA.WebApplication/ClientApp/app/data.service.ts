import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from './models/user';
import { Plot } from './models/plot';

@Injectable()
export class DataService {

    private urlUser = "/api/users";
    private urlPlot = "/api/plots";

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
}