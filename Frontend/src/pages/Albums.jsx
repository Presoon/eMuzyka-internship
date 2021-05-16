import "../assets/css/App.css";
import API from "../services/APIcontext"
import AlbumCard from "../components/albumcard/AlbumCard"
import React, {useEffect, useState} from "react";

const Albums = () => {
    const [albums, setAlbums] = useState([]);
    useEffect(() => {
      const fetchData = async () => {
        const result = await API.getAllAlbums().catch((err) => {
          console.error(err);
          var data = 0;
          return data;
        });
        setAlbums(result.data);
      };

      fetchData();
    }, []);


  return (
    
    <div className="container">
      <div className="row">
        <h1 className="titlex position-relative mt-5 mt-5 mb-5 ">
          Twoje albumy
        </h1>
      </div>
      <div className="row justify-content-center">
        {albums && albums.map((album) => {
          console.log(album);
          return <AlbumCard key={album.id} album={album} />;
        })}
      </div>
    </div>
  );
};

export default Albums;
