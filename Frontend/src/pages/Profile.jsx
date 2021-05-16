import "../assets/css/App.css";
import React, {useEffect, useState} from "react";
import API from "../services/APIcontext.js"

const Profile = () => {
    const [provider, setProvider] = useState("");
    useEffect(() => {
      const fetchData = async () => {
        const result = await API.getProviderInfo().catch((err) => {
          console.error(err);
          var data = 0;
          return data;
        });
        setProvider(result.data);
      };

      fetchData();
    }, []);

  

  return (
    <div className="container">
      <div className="row">
        <h1 className="titlex position-relative mt-5 mt-5 mb-5 ">
          Informacje dotyczące profilu
        </h1>
      </div>
      {provider && (
        <div className="row justify-content-center">
          <div className="col-md-9 col-lg-12 col-xl-10">
            <div className="card shadow-lg o-hidden border-0 my-5">
              <div className="card-body p-0">
                <div className="row">
                  <div className="col-md-4">
                    <div className="card h-100">
                      <div className="card-body">
                        <div className="d-flex flex-column align-items-center text-center">
                          <img
                            src="https://bootdey.com/img/Content/avatar/avatar7.png"
                            alt="Admin"
                            className="rounded-circle"
                            width="150"
                          />
                          <div className="mt-3">
                            <h4>
                              {provider.name}&nbsp;{provider.lastName}
                            </h4>
                            <p className="text-secondary mb-1">
                              Dostawca muzyczny
                            </p>
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                  <div className="col-md-8">
                    <div className="card">
                      <div className="card-body">
                        <div className="row">
                          <div className="col-sm-3">
                            <h6 className="mb-0">Id konta:</h6>
                          </div>
                          <div className="col-sm-9 text-secondary">
                            {provider.id}
                          </div>
                        </div>
                        <hr />
                        <div className="row">
                          <div className="col-sm-3">
                            <h6 className="mb-0">Login:</h6>
                          </div>
                          <div className="col-sm-9 text-secondary">
                            {provider.userName}
                          </div>
                        </div>
                        <hr />
                        <div className="row">
                          <div className="col-sm-3">
                            <h6 className="mb-0">Email:</h6>
                          </div>
                          <div className="col-sm-9 text-secondary">
                            {provider.email}
                          </div>
                        </div>
                        <hr />
                        <div className="row">
                          <div className="col-sm-3">
                            <h6 className="mb-0">Konto od:</h6>
                          </div>
                          <div className="col-sm-9 text-secondary">
                            {provider.createdAt.toString().substring(0, 10)}
                          </div>
                        </div>
                        <hr />
                        <div className="row">
                          <div className="col-sm-3">
                            <h6 className="mb-0">Albumy:</h6>
                          </div>
                          <div className="col-sm-9 text-secondary">
                            {provider.albums.length}
                          </div>
                        </div>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      )}
    </div>
  );
};

export default Profile;
